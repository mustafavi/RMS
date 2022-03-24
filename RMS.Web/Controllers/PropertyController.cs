using Microsoft.AspNetCore.Mvc;
using RMS.Data.Models2;
using RMS.Infrastructure;
using RMS.Web.ViewModel;

namespace RMS.Web.Controllers
{
    public class PropertyController : Controller
    {
        private IUnitOfWork unitOfWork;
        public PropertyController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var properties = unitOfWork.PropertyRepo.GetAll();
            return View(properties);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PropertyModel model)
        {
            //if (ModelState.IsValid)
            //{
            var propertyObj = new Property()
            {

                PropertyAddress = model.PropertyAddress,
                Description = model.Description,
            };


            //var flatObj = new Flat()
            //{ 
            // FlatAddress = model.Flats.FlatAddress,
            //  Property = propertyObj
            //};

            unitOfWork.PropertyRepo.Add(propertyObj);
            unitOfWork.SaveChanges();
            //}

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var model = unitOfWork.PropertyRepo.Get(id);
            
            /*
            var flats = new List<Flat>()
            {
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 101, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 102, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 103, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 104, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 105, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 106, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 107, Bradford"},

                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 201, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 202, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 203, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 204, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 205, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 206, Bradford"},
                new Flat{ FlatId = new Guid(), FlatAddress = "28 Howard Street, flat 207, Bradford"},



                new Flat{ FlatId = new Guid(), FlatAddress = "33 South Street, Bristol"},
                new Flat{ FlatId = new Guid(), FlatAddress = "33 Fenwick Place London"},
                new Flat{ FlatId = new Guid(), FlatAddress = "25 PageHall Road, Sheffield"},
                new Flat{ FlatId = new Guid(), FlatAddress = "496 WashwoodHeath Road, Brimingham"},
            };
            ViewBag.list = new SelectList(flats, "FlatId", "FlatAddress");
            */

            var propertyModel = new PropertyModel();
            var flatsFromRepo = unitOfWork.FlatRepo.GetAll();


            // propertyModel.Flats = flats;
            propertyModel.Flats = flatsFromRepo.ToList();
            // ViewBag.list = new SelectList(flats, "FlatId", "FlatAddress");

            propertyModel.PropertyAddress = model.PropertyAddress;
            propertyModel.Description = model.Description;


            return View(model);
        }
    }
}
