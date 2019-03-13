using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WCF.Service
{
    /// <summary>
    /// 定义了一个接口，通过在接口上应用System.ServiceModel命名空间下的ServiceContractAttribute特性将ICanaolServices接口定义成服务契约
    /// </summary>
    [ServiceContract(Name = "ICanaolServices")]
    public interface ICanaolServices
    {
        /// <summary>
        /// 定义操作契约
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double jia(double x, double y);
        /// <summary>
        /// 定义操作契约
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double jian(double x, double y);
    }
}
