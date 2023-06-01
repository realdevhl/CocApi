using System;
using Microsoft.Extensions.DependencyInjection;


namespace CocApi.Rest.Client
{
    /// <summary>
    /// An IApiFactory interface
    /// </summary>
    public interface IApiFactory
    {
        /// <summary>
        /// A method to create an IApi of type IResult
        /// </summary>
        /// <typeparam name="IResult"></typeparam>
        /// <returns></returns>
        IResult Create<IResult>() where IResult : IBaseApis.IApi;
    }

    /// <summary>
    /// An ApiFactory
    /// </summary>
    public class ApiFactory : IApiFactory
    {
        /// <summary>
        /// The service provider
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiFactory"/> class.
        /// </summary>
        /// <param name="services"></param>
        public ApiFactory(IServiceProvider services)
        {
            Services = services;
        }

        /// <summary>
        /// A method to create an IApi of type IResult
        /// </summary>
        /// <typeparam name="IResult"></typeparam>
        /// <returns></returns>
        public IResult Create<IResult>() where IResult : IBaseApis.IApi
        {
            return Services.GetRequiredService<IResult>();
        }
    }
}
