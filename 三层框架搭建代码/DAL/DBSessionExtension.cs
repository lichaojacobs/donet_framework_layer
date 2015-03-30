
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DALMSSQL
{
	public partial class DBSession:IDAL.IDBSession
    {
		#region 01 数据接口 IBill_LeaveDAL
		IBill_LeaveDAL iBill_LeaveDAL;
		public IBill_LeaveDAL IBill_LeaveDAL
		{
			get
			{
				if(iBill_LeaveDAL==null)
					iBill_LeaveDAL= new Bill_LeaveDAL();
				return iBill_LeaveDAL;
			}
			set
			{
				iBill_LeaveDAL= value;
			}
		}
		#endregion

		#region 02 数据接口 IOu_DepartmentDAL
		IOu_DepartmentDAL iOu_DepartmentDAL;
		public IOu_DepartmentDAL IOu_DepartmentDAL
		{
			get
			{
				if(iOu_DepartmentDAL==null)
					iOu_DepartmentDAL= new Ou_DepartmentDAL();
				return iOu_DepartmentDAL;
			}
			set
			{
				iOu_DepartmentDAL= value;
			}
		}
		#endregion

		#region 03 数据接口 IOu_PermissionDAL
		IOu_PermissionDAL iOu_PermissionDAL;
		public IOu_PermissionDAL IOu_PermissionDAL
		{
			get
			{
				if(iOu_PermissionDAL==null)
					iOu_PermissionDAL= new Ou_PermissionDAL();
				return iOu_PermissionDAL;
			}
			set
			{
				iOu_PermissionDAL= value;
			}
		}
		#endregion

		#region 04 数据接口 IOu_RoleDAL
		IOu_RoleDAL iOu_RoleDAL;
		public IOu_RoleDAL IOu_RoleDAL
		{
			get
			{
				if(iOu_RoleDAL==null)
					iOu_RoleDAL= new Ou_RoleDAL();
				return iOu_RoleDAL;
			}
			set
			{
				iOu_RoleDAL= value;
			}
		}
		#endregion

		#region 05 数据接口 IOu_RolePermissionDAL
		IOu_RolePermissionDAL iOu_RolePermissionDAL;
		public IOu_RolePermissionDAL IOu_RolePermissionDAL
		{
			get
			{
				if(iOu_RolePermissionDAL==null)
					iOu_RolePermissionDAL= new Ou_RolePermissionDAL();
				return iOu_RolePermissionDAL;
			}
			set
			{
				iOu_RolePermissionDAL= value;
			}
		}
		#endregion

		#region 06 数据接口 IOu_UserInfoDAL
		IOu_UserInfoDAL iOu_UserInfoDAL;
		public IOu_UserInfoDAL IOu_UserInfoDAL
		{
			get
			{
				if(iOu_UserInfoDAL==null)
					iOu_UserInfoDAL= new Ou_UserInfoDAL();
				return iOu_UserInfoDAL;
			}
			set
			{
				iOu_UserInfoDAL= value;
			}
		}
		#endregion

		#region 07 数据接口 IOu_UserRoleDAL
		IOu_UserRoleDAL iOu_UserRoleDAL;
		public IOu_UserRoleDAL IOu_UserRoleDAL
		{
			get
			{
				if(iOu_UserRoleDAL==null)
					iOu_UserRoleDAL= new Ou_UserRoleDAL();
				return iOu_UserRoleDAL;
			}
			set
			{
				iOu_UserRoleDAL= value;
			}
		}
		#endregion

		#region 08 数据接口 IOu_UserVipPermissionDAL
		IOu_UserVipPermissionDAL iOu_UserVipPermissionDAL;
		public IOu_UserVipPermissionDAL IOu_UserVipPermissionDAL
		{
			get
			{
				if(iOu_UserVipPermissionDAL==null)
					iOu_UserVipPermissionDAL= new Ou_UserVipPermissionDAL();
				return iOu_UserVipPermissionDAL;
			}
			set
			{
				iOu_UserVipPermissionDAL= value;
			}
		}
		#endregion

		#region 09 数据接口 IWF_AutoTransactNodeDAL
		IWF_AutoTransactNodeDAL iWF_AutoTransactNodeDAL;
		public IWF_AutoTransactNodeDAL IWF_AutoTransactNodeDAL
		{
			get
			{
				if(iWF_AutoTransactNodeDAL==null)
					iWF_AutoTransactNodeDAL= new WF_AutoTransactNodeDAL();
				return iWF_AutoTransactNodeDAL;
			}
			set
			{
				iWF_AutoTransactNodeDAL= value;
			}
		}
		#endregion

		#region 10 数据接口 IWF_BillFlowNodeDAL
		IWF_BillFlowNodeDAL iWF_BillFlowNodeDAL;
		public IWF_BillFlowNodeDAL IWF_BillFlowNodeDAL
		{
			get
			{
				if(iWF_BillFlowNodeDAL==null)
					iWF_BillFlowNodeDAL= new WF_BillFlowNodeDAL();
				return iWF_BillFlowNodeDAL;
			}
			set
			{
				iWF_BillFlowNodeDAL= value;
			}
		}
		#endregion

		#region 11 数据接口 IWF_BillFlowNodeRemarkDAL
		IWF_BillFlowNodeRemarkDAL iWF_BillFlowNodeRemarkDAL;
		public IWF_BillFlowNodeRemarkDAL IWF_BillFlowNodeRemarkDAL
		{
			get
			{
				if(iWF_BillFlowNodeRemarkDAL==null)
					iWF_BillFlowNodeRemarkDAL= new WF_BillFlowNodeRemarkDAL();
				return iWF_BillFlowNodeRemarkDAL;
			}
			set
			{
				iWF_BillFlowNodeRemarkDAL= value;
			}
		}
		#endregion

		#region 12 数据接口 IWF_BillStateDAL
		IWF_BillStateDAL iWF_BillStateDAL;
		public IWF_BillStateDAL IWF_BillStateDAL
		{
			get
			{
				if(iWF_BillStateDAL==null)
					iWF_BillStateDAL= new WF_BillStateDAL();
				return iWF_BillStateDAL;
			}
			set
			{
				iWF_BillStateDAL= value;
			}
		}
		#endregion

		#region 13 数据接口 IWF_NodeDAL
		IWF_NodeDAL iWF_NodeDAL;
		public IWF_NodeDAL IWF_NodeDAL
		{
			get
			{
				if(iWF_NodeDAL==null)
					iWF_NodeDAL= new WF_NodeDAL();
				return iWF_NodeDAL;
			}
			set
			{
				iWF_NodeDAL= value;
			}
		}
		#endregion

		#region 14 数据接口 IWF_NodeStateDAL
		IWF_NodeStateDAL iWF_NodeStateDAL;
		public IWF_NodeStateDAL IWF_NodeStateDAL
		{
			get
			{
				if(iWF_NodeStateDAL==null)
					iWF_NodeStateDAL= new WF_NodeStateDAL();
				return iWF_NodeStateDAL;
			}
			set
			{
				iWF_NodeStateDAL= value;
			}
		}
		#endregion

		#region 15 数据接口 IWF_WorkFlowDAL
		IWF_WorkFlowDAL iWF_WorkFlowDAL;
		public IWF_WorkFlowDAL IWF_WorkFlowDAL
		{
			get
			{
				if(iWF_WorkFlowDAL==null)
					iWF_WorkFlowDAL= new WF_WorkFlowDAL();
				return iWF_WorkFlowDAL;
			}
			set
			{
				iWF_WorkFlowDAL= value;
			}
		}
		#endregion

		#region 16 数据接口 IWF_WorkFlowNodeDAL
		IWF_WorkFlowNodeDAL iWF_WorkFlowNodeDAL;
		public IWF_WorkFlowNodeDAL IWF_WorkFlowNodeDAL
		{
			get
			{
				if(iWF_WorkFlowNodeDAL==null)
					iWF_WorkFlowNodeDAL= new WF_WorkFlowNodeDAL();
				return iWF_WorkFlowNodeDAL;
			}
			set
			{
				iWF_WorkFlowNodeDAL= value;
			}
		}
		#endregion

    }

}