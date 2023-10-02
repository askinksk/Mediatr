using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GettAllProductQuery : IRequest<List<GetProductViewModel>>
    {

        public class GettAllProductQueryHandler : IRequestHandler<GettAllProductQuery, List<GetProductViewModel>>
        {
            public Task<List<GetProductViewModel>> Handle(GettAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Book"
                };

                var model2 = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitör"
                };
                return Task.FromResult(new List<GetProductViewModel> { model2 });
            }
        }
    }
}
