using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Unity;
using Unity.Resolution;

namespace Nitrogen.IOC
{
    /// <summary>
    /// IOC容器。
    /// </summary>
    public class UnityIocHelper
    {
        /// <summary>
        /// 容器初始化。
        /// </summary>
        /// <param name="containerName">容器名称。</param>
        private UnityIocHelper(string containerName)
        {
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            if (containerName == "IOCcontainer")
            {
                _container = new UnityContainer();
                section.Configure(_container, containerName);
            }
            else if (section.Containers.Count > 1)
            {
                _container = new UnityContainer();
                section.Configure(_container, containerName);
            }
        }

        private readonly IUnityContainer _container;

        /// <summary>
        /// UnityIoc容器实例
        /// </summary>
        public static UnityIocHelper Instance { get; } = new UnityIocHelper("IOCcontainer");

        /// <summary>
        /// 获取实现类(默认映射)
        /// </summary>
        /// <typeparam name="T">接口类型</typeparam>
        /// <returns>接口</returns>
        public T GetService<T>()
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        /// 获取实现类(默认映射)带参数的
        /// </summary>
        /// <typeparam name="T">接口类型</typeparam>
        /// <param name="parameter">参数</param>
        /// <returns>接口</returns>
        public T GetService<T>(params ParameterOverride[] parameter)
        {
            return _container.Resolve<T>(parameter);
        }
        /// <summary>
        /// 获取实现类(指定映射)带参数的
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="parameter"></param>
        /// <returns>接口</returns>
        public T GetService<T>(string name, params ParameterOverride[] parameter)
        {
            return _container.Resolve<T>(name, parameter);
        }

        /// <summary>
        /// 判断接口是否被实现了
        /// </summary>
        /// <typeparam name="T">接口类型</typeparam>
        /// <returns>bool</returns>
        public bool IsResolve<T>()
        {
            return _container.IsRegistered<T>();
        }
        /// <summary>
        /// 判断接口是否被实现了
        /// </summary>
        /// <typeparam name="T">接口类型</typeparam>
        /// <param name="name">映射名称</param>
        /// <returns></returns>
        public bool IsResolve<T>(string name)
        {
            return _container.IsRegistered<T>(name);
        }

    }
}
