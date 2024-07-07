using Ardalis.GuardClauses;
using Educar.Backend.Application.Commands.Contract.CreateAccountType;
using Educar.Backend.Application.Commands.Contract.DeleteContract;
using Educar.Backend.Application.Queries.Contract;
using Educar.Backend.Domain.Entities;
using Educar.Backend.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using static Educar.Backend.Application.IntegrationTests.Testing;

namespace Educar.Backend.Application.IntegrationTests.Contract;

[TestFixture]
public class DeleteContractTests : TestBase
{
    private Domain.Entities.Client _client;

    [SetUp]
    public void SetUp()
    {
        ResetState();

        // Create and add a client to the context
        _client = new Domain.Entities.Client("test client");
        Context.Clients.Add(_client);
        Context.SaveChanges();
    }

    [Test]
    public async Task GivenValidRequest_ShouldSoftDeleteContract()
    {
        // Arrange
        var createCommand = new CreateContractCommand(_client.Id)
        {
            ContractDurationInYears = 1,
            ContractSigningDate = DateTimeOffset.Now,
            ImplementationDate = DateTimeOffset.Now.AddMonths(1),
            TotalAccounts = 10,
            Status = ContractStatus.Signed
        };
        var createResponse = await SendAsync(createCommand);

        var deleteCommand = new DeleteContractCommand(createResponse.Id);

        // Act
        await SendAsync(deleteCommand);

        // Assert
        var deletedContract = await Context.Contracts.IgnoreQueryFilters()
            .FirstOrDefaultAsync(c => c.Id == createResponse.Id);
        Assert.That(deletedContract, Is.Not.Null);
        Assert.That(deletedContract.IsDeleted, Is.True);
        Assert.That(deletedContract.DeletedAt, Is.Not.Null);
    }

    [Test]
    public void GivenInvalidRequest_ShouldThrowNotFoundException()
    {
        // Arrange
        var deleteCommand = new DeleteContractCommand(Guid.NewGuid());

        // Act & Assert
        Assert.ThrowsAsync<NotFoundException>(async () => await SendAsync(deleteCommand));
    }

    [Test]
    public async Task GivenSoftDeletedContract_ShouldNotRetrieveIt()
    {
        // Arrange
        var createCommand = new CreateContractCommand(_client.Id)
        {
            ContractDurationInYears = 1,
            ContractSigningDate = DateTimeOffset.Now,
            ImplementationDate = DateTimeOffset.Now.AddMonths(1),
            TotalAccounts = 10,
            Status = ContractStatus.Signed
        };
        var createResponse = await SendAsync(createCommand);

        var deleteCommand = new DeleteContractCommand(createResponse.Id);
        await SendAsync(deleteCommand);

        var query = new GetContractQuery { Id = createResponse.Id };

        // Act & Assert
        Assert.ThrowsAsync<NotFoundException>(async () => await SendAsync(query));
    }
}