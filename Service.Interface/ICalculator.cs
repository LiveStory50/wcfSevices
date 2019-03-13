using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Service.Interface
{
    [ServiceContract(Name = "CalculatorService",Namespace="http://www.artech.com/")]

    public interface ICalculator
    {
        /// <summary>
        /// 加
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Add(double x, double y);

        /// <summary>
        /// 减
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Subtract(double x, double y);

        /// <summary>
        /// 乘
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Multiply(double x, double y);

        /// <summary>
        /// 除
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Divide(double x, double y);
    }
}
