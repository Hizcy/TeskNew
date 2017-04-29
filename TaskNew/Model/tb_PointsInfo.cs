// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_PointsInfo.cs
// 项目名称：买车网
// 创建时间：2015/10/20
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_PointsInfo数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_PointsInfoEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private int _type;
		///<summary>
		///
		///</summary>
		private int _point;
		///<summary>
		///
		///</summary>
		private decimal _rate;
		///<summary>
		///
		///</summary>
		private decimal _money;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_PointsInfoEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_PointsInfoEntity
		(
			int id,
			int userId,
			int type,
			int point,
			decimal rate,
			decimal money,
			DateTime addtime
		)
		{
			_id      = id;
			_userId  = userId;
			_type    = type;
			_point   = point;
			_rate    = rate;
			_money   = money;
			_addtime = addtime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Type
		{
			get {return _type;}
			set {_type = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Point
		{
			get {return _point;}
			set {_point = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Rate
		{
			get {return _rate;}
			set {_rate = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Money
		{
			get {return _money;}
			set {_money = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime
		{
			get {return _addtime;}
			set {_addtime = value;}
		}
	
		#endregion
		
	}
}
