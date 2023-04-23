using CQRS_Example.Domain;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Example.Aplication
{
    public class ProductCollection
    {
        public class Query : IRequest<List<Product>>
        {

        }

        public class Handler : IRequestHandler<Query, List<Product>>
        {
            public Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Task.FromResult(
                    new List<Product>() {
                        new Product(){
                            Code = 1,
                            Name = "PS5"
                        },
                        new Product(){
                            Code = 2,
                            Name = "TV Samsung QN90B"
                        }
                    }
                );

            }
        }
    }
}
