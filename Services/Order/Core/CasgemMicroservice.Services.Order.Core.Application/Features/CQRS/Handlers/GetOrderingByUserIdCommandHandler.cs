﻿using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetOrderingByUserIdCommandHandler : IRequestHandler<GetOrderingByUserIdQueryRequest, List<ResultOrderingDto>>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetOrderingByUserIdCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultOrderingDto>> Handle(GetOrderingByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetOrdersById(x => x.UserID == request.Id);
            return _mapper.Map<List<ResultOrderingDto>>(value);
        }
    }
}
