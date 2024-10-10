using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using DataAccessLayer.Repository.EstateAgentRepository.DashboardRepository.ChartRepository;
using DataAccessLayer.Repository.EstateAgentRepository.DashboardRepository.LastPropertyRepository;
using DataAccessLayer.Repository.EstateAgentRepository.DashboardRepository.StatisticRepository;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection Services)
        {
            Services.AddTransient<Context>();

            Services.AddTransient<ICategoryService, CategoryManager>();
            Services.AddTransient<ICategoryDal, CategoryRepository>();

            Services.AddTransient<IPropertyService, PropertyManager>();
            Services.AddTransient<IPropertyDal, PropertyRepository>();

            Services.AddTransient<IWhoWeAreService, WhoWeAreManager>();
            Services.AddTransient<IWhoWeAreDal, WhoWeAreRepository>();

            Services.AddTransient<IServiceService, ServiceManager>();
            Services.AddTransient<IServiceDal, ServiceRepository>();

            Services.AddTransient<IBottomGridService, BottomGridManager>();
            Services.AddTransient<IBottomGridDal, BottomGridRepository>();

            Services.AddTransient<IPopularLocationService, PopularLocationManager>();
            Services.AddTransient<IPopularLocationDal, PopularLocationRepository>();

            Services.AddTransient<ITestimonialService, TestimonialManager>();
            Services.AddTransient<ITestimonialDal, TestimonialRepository>();

            Services.AddTransient<IEmpolyeeService, EmpolyeeManager>();
            Services.AddTransient<IEmpolyeeDal, EmpolyeeRepository>();

            Services.AddTransient<IStatisticsService, StatisticsManager>();
            Services.AddTransient<IStatisticsDal, StatisticsRepository>();

            Services.AddTransient<IContactService, ContactManager>();
            Services.AddTransient<IContactDal, ContactRepository>();

            Services.AddTransient<IToDoListService, ToDoListManager>();
            Services.AddTransient<IToDoListDal, ToDoListRepository>();

            Services.AddTransient<IStatisticService, StatisticManager>();
            Services.AddTransient<IStatisticDal, StatisticRepository>();

            Services.AddTransient<IChartService, ChartManager>();
            Services.AddTransient<IChartDal, ChartRepository>();

            Services.AddTransient<ILastPropertyService, LastPropertyManager>();
            Services.AddTransient<ILastPropertyDal, LastPropertyRepository>();

            Services.AddTransient<IMessageService, MessageManager>();
            Services.AddTransient<IMessageDal, MessageRepository>();

            Services.AddTransient<IPropertyDetailService, PropertyDetailManager>();
            Services.AddTransient<IPropertyDetailDal, PropertyDetailRepository>();

            Services.AddTransient<IPropertyImageService, PropertyImageManager>();
            Services.AddTransient<IPropertyImageDal, PropertyImageRepository>();

            Services.AddTransient<IAppUserService, AppUserManager>();
            Services.AddTransient<IAppUserDal, AppUserRepository>();

            Services.AddTransient<IAmenityService, AmenityManager>();
            Services.AddTransient<IAmenityDal, AmenityRepository>();

            Services.AddTransient<IPropertyAmenityService, PropertyAmenityManager>();
            Services.AddTransient<IPropertyAmenityDal, PropertyAmenityRepository>();

            Services.AddTransient<ISubFeatureService, SubFeatureManager>();
            Services.AddTransient<ISubFeatureDal, SubFeatureRepository>();

            Services.AddTransient<IAddressService, AddressManager>();
            Services.AddTransient<IAddressDal, AddressRepository>();

            Services.AddTransient<ISocialMediaService, SocialMediaManager>();
            Services.AddTransient<ISocialMediaDal, SocialMediaRepository>();

            Services.AddTransient<IMailSubscribeService, MailSubscribeManager>();
            Services.AddTransient<IMailSubscribeDal, MailSubscribeRepository>();

            Services.AddTransient<IBrandService, BrandManager>();
            Services.AddTransient<IBrandDal, BrandRepository>();
        }
        public static void CustomerValidator(this IServiceCollection services)
        {
            //    services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementAddValidator>();
            //    services.AddTransient<IValidator<AnnouncementUpdateDTO>, AnnouncementUpdateValidator>();
            //    services.AddTransient<IValidator<AnnouncementListDTO>, AnnouncementListValidator>();
            //    services.AddTransient<IValidator<AppRoleAddDTO>, AppRoleAddValidator>();
            //    services.AddTransient<IValidator<AppUserRegisterDTO>, AppUserRegisterValidator>();
            //    services.AddTransient<IValidator<AppUserResetPasswordDTO>, AppUserResetPasswordValidator>();
            //    services.AddTransient<IValidator<AppUserForGetPasswordDTO>, AppUserForGetPasswordValidator>();
            //    services.AddTransient<IValidator<AppUserSinginDTO>, AppUserSinginValidator>();
            //    services.AddTransient<IValidator<ReplyMessageDTO>, ReplyMessageValidator>();
            //    services.AddTransient<IValidator<SendMessageDTO>, SendContactUsValidator>();
            //    services.AddTransient<IValidator<DestinationAddDTO>, DestinationAddValidator>();
            //    services.AddTransient<IValidator<DestinationModelDTO>, DestinationModelValidator>();
            //    services.AddTransient<IValidator<MailRequestDTO>, MailRequestValidator>();
            //    services.AddTransient<IValidator<AboutViewDTO>, AboutViewValidator>();
            //    services.AddTransient<IValidator<RoleAssignViewDTO>, AppRoleAssignValidator>();
            //    services.AddTransient<IValidator<UpdateRoleViewDTO>, AppRoleUpdateValidator>();
            //    services.AddTransient<IValidator<CreateRoleViewDTO>, AppRoleCreateValidator>();
            //    services.AddTransient<IValidator<DestinationViewDTO>, DestinationViewValidator>();
            //    services.AddTransient<IValidator<GuideProfileEditViewDTO>, GuideProfileEditViewValidator>();
            //    services.AddTransient<IValidator<GuideViewDTO>, GuideValidator>();
            //    services.AddTransient<IValidator<FeatureViewDTO>, FeatureValidator>();
            //    services.AddTransient<IValidator<Feature2ViewDTO>, Feature2Validator>();
            //    services.AddTransient<IValidator<UserEditViewDTO>, UserEditViewValidator>();
            //    services.AddTransient<IValidator<AdminUserEditViewDTO>, AdminUserEditViewValidator>();
        }
    }
}