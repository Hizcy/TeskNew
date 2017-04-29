// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Template.cs
// 项目名称：买车网
// 创建时间：2015/11/9
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Task.Entity
{
	/// <summary>
	///tb_Template数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_TemplateEntity
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
		private string _templateName = String.Empty;
		///<summary>
		///
		///</summary>
		private int _taskId;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_TemplateEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_TemplateEntity
		(
			int id,
			int userId,
			string templateName,
			int taskId
		)
		{
			_id           = id;
			_userId       = userId;
			_templateName = templateName;
			_taskId       = taskId;
			
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
		public string TemplateName
		{
			get {return _templateName;}
			set {_templateName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int TaskId
		{
			get {return _taskId;}
			set {_taskId = value;}
		}
	
		#endregion
		
	}
}
