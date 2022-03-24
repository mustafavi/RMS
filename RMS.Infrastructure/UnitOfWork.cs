using RMS.Data.Models2;
using RMS.Infrastructure.Repositories;

namespace RMS.Infrastructure
{

    public interface IUnitOfWork
    {
        IRepository<Bill> BillRepo { get; }
        IRepository<Expense> ExpenseRepo { get; }
        IRepository<Flat> FlatRepo { get; }
        IRepository<Property> PropertyRepo { get; }
        IRepository<Rent> RentRepo { get; }
        IRepository<Tenant> TenantRepo { get; }
        void SaveChanges();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private RMSContext context;
        public UnitOfWork(RMSContext context)
        {
            this.context = context;
        }

        private IRepository<Bill> billRepo;

        public IRepository<Bill> BillRepo
        {
            get
            {
                if (billRepo == null)
                {
                    billRepo = new BillRepository(context);
                }
                return billRepo;
            }
        }

        private IRepository<Expense> expense;
        public IRepository<Expense> ExpenseRepo
        {
            get
            {
                if (expense == null)
                {
                    expense = new ExpenseRepository(context);
                }
                return expense;
            }
        }

        private IRepository<Flat> flatRepo;
        public IRepository<Flat> FlatRepo
        {
            get
            {
                if (flatRepo == null)
                {
                    flatRepo = new FlatRepository(context);
                }
                return flatRepo;
            }
        }


        private IRepository<Property> propertyRepo;
        public IRepository<Property> PropertyRepo
        {
            get
            {
                if (propertyRepo == null)
                {
                    propertyRepo = new PropertyRepository(context);
                }
                return propertyRepo;
            }
        }

        private IRepository<Rent> rentRepo;
        public IRepository<Rent> RentRepo
        {
            get
            {
                if (rentRepo == null)
                {
                    rentRepo = new RentRepository(context);
                }
                return rentRepo;
            }
        }

        private IRepository<Tenant> tenantRepo;
        public IRepository<Tenant> TenantRepo
        {
            get
            {
                if (tenantRepo == null)
                { tenantRepo = new TenantRepository(context); }
                return tenantRepo;
            }
        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
