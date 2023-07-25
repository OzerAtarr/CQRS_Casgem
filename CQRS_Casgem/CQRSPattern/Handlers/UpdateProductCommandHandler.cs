using CQRS_Casgem.CQRSPattern.Commands;
using CQRS_Casgem.DAL;

namespace CQRS_Casgem.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProdactCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Brand = command.Brand;
            values.Price = command.Price;
            values.Stock = command.Stock;
            values.Category = command.Category;
            values.Name = command.Name;
            _context.SaveChanges();
        }
    }
}
