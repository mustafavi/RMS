using RMS.Data.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RMS.Infrastructure.Repositories
{
    public class FlatRepository : GenericRepository<Flat>
    {
        public FlatRepository(RMSContext context) : base(context)
        {
        }

        public override IEnumerable<Flat> GetAll()
        { 
                return context.Flats.ToList();
        }

    //public override IEnumerable<Flat> GetAll()
    //{
    //    // Lazy Loading: Value Holder
    //    //ProfilePictureValueHolder = new ValueHolder<byte[]>();
    //    //ProfilePictureValueHolder = new Lazy<byte[]>(() =>
    //    //{
    //    //    return ProfilePictureService.GetFor(customer.Name);
    //    //});

    //    return base.GetAll().ToList();
    //}


    public override IEnumerable<Flat> Find(Expression<Func<Flat, bool>> predicate)
    {
        return context.Flats
            .Include(p => p.Property)
            //.ThenInclude(lineItem => lineItem.Product)
            .Where(predicate).ToList();
    }

}

}
