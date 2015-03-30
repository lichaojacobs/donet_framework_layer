
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
	public partial interface IDBSession
    {
		IBill_LeaveDAL IBill_LeaveDAL{get;set;}
		IOu_DepartmentDAL IOu_DepartmentDAL{get;set;}
		IOu_PermissionDAL IOu_PermissionDAL{get;set;}
		IOu_RoleDAL IOu_RoleDAL{get;set;}
		IOu_RolePermissionDAL IOu_RolePermissionDAL{get;set;}
		IOu_UserInfoDAL IOu_UserInfoDAL{get;set;}
		IOu_UserRoleDAL IOu_UserRoleDAL{get;set;}
		IOu_UserVipPermissionDAL IOu_UserVipPermissionDAL{get;set;}
		IWF_AutoTransactNodeDAL IWF_AutoTransactNodeDAL{get;set;}
		IWF_BillFlowNodeDAL IWF_BillFlowNodeDAL{get;set;}
		IWF_BillFlowNodeRemarkDAL IWF_BillFlowNodeRemarkDAL{get;set;}
		IWF_BillStateDAL IWF_BillStateDAL{get;set;}
		IWF_NodeDAL IWF_NodeDAL{get;set;}
		IWF_NodeStateDAL IWF_NodeStateDAL{get;set;}
		IWF_WorkFlowDAL IWF_WorkFlowDAL{get;set;}
		IWF_WorkFlowNodeDAL IWF_WorkFlowNodeDAL{get;set;}
    }

}