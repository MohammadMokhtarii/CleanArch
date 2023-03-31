using CleanArch.Domain.Base;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CleanArch.Infrastructure.Persistence;

public partial class UnitOfWork 
{
    public IPersonRepo PersonRepo => _dbContext.GetService<IPersonRepo>();
}
