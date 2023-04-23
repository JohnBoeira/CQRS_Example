using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Example.Aplication
{
    public class ProductCreate
    {
        public class Command : IRequest {
            public string Name { get; set; }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            public Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                return Unit.Task;
            }
        }
    }
}
