/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2010 Seapeak.Xu / xvhfeng                                                                       *
* FastDFS .Net Client may be copied only under the terms of the GNU General Public License V3,                  *
* which may be found in the FastDFS .Net Client source kit.                                                     *
* Please visit the FastDFS .Net Client Home Page https://code.google.com/p/fastdfs-net-client/ for more detail. *
*                                                                                                               *
****************************************************************************************************************/

namespace FastDFS.Client.Core.Pool
{
    /// <summary>
    /// ����ػ�����
    /// </summary>
    public interface IPoolableObjectFactory<T>
    {
        /// <summary>
        /// ��������
        /// </summary>
        T CreateObject();

        /// <summary>
        /// ���ٶ���.
        /// </summary>
        void DestroyObject(T obj);

        /// <summary>
        /// ��鲢ȷ������İ�ȫ
        /// </summary>
        bool ValidateObject(T obj);

        /// <summary>
        /// ���������еĴ��ö���. 
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="ipAddress">The ip address.</param>
        /// <param name="port">The port.</param>
        void ActivateObject(T obj, string ipAddress, int port);

        /// <summary>
        /// ж���ڴ�������ʹ�õĶ���.
        /// </summary>
        void PassivateObject(T obj);

    }
}