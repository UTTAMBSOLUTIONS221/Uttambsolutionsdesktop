using DBL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.UOW
{
    public interface IUnitOfWork
    {
        ISecurityRepository SecurityRepository { get; }
        //ISalesTransactionRepository SalesTransactionRepository { get; }
        //IDashboardRepository DashboardRepository { get; }
        //IGeneralRepository GeneralRepository { get; }
        //ICustomerRepository CustomerRepository { get; }
        //IProductRepository ProductRepository { get; }
        //ISettingsRepository SettingsRepository { get; }
        //ISetupRepository SetupRepository { get; }
        //IStationRepository StationRepository { get; }
        //ILoyaltyRepository LoyaltyRepository { get; }
        //IPriceRepository PriceRepository { get; }
    }
}
