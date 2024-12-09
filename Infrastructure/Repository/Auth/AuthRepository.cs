
using AutoMapper;
using Domain.Entities.Plans;
using Domain.Repository.Auth;
using Domain.Repository.Plans;
using Infrastructure.DataSource.Seeds;
using Infrastructure.Models.Plans;
using Shared.Settings;

namespace Infrastructure.Repository.Plans
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SeedsPlans seedsPlans;
        private readonly IMapper _mapper;
        private readonly ApplicationModeService appModeService;
        public AuthRepository(IMapper mapper, ApplicationModeService appModeService)
        {

            seedsPlans = new SeedsPlans();
            _mapper = mapper;
            this.appModeService = appModeService;
        }




    }
}
