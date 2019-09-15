using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IService
{
    public interface IBaseService<T> where T:BaseEntity
    {
        /// <summary>
        /// 获取数据集合
        /// </summary>
        DbSet<T> Entities { get; }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<T> Index();
        /// <summary>
        /// 增加单个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Insert(T entity);

        /// <summary>
        /// 增加多个实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Insert(IEnumerable<T> entities);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(T entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int ids);

        /// <summary>
        /// 根据逐渐获取实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetModelById(object key);
    }
}
