
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
	public partial interface IBill_LeaveDAL : IBaseDAL<MODEL.Bill_Leave>
    {
    }

	public partial interface IOu_DepartmentDAL : IBaseDAL<MODEL.Ou_Department>
    {
    }

	public partial interface IOu_PermissionDAL : IBaseDAL<MODEL.Ou_Permission>
    {
    }

	public partial interface IOu_RoleDAL : IBaseDAL<MODEL.Ou_Role>
    {
    }

	public partial interface IOu_RolePermissionDAL : IBaseDAL<MODEL.Ou_RolePermission>
    {
    }

	public partial interface IOu_UserInfoDAL : IBaseDAL<MODEL.Ou_UserInfo>
    {
    }

	public partial interface IOu_UserRoleDAL : IBaseDAL<MODEL.Ou_UserRole>
    {
    }

	public partial interface IOu_UserVipPermissionDAL : IBaseDAL<MODEL.Ou_UserVipPermission>
    {
    }

	public partial interface IWF_AutoTransactNodeDAL : IBaseDAL<MODEL.WF_AutoTransactNode>
    {
    }

	public partial interface IWF_BillFlowNodeDAL : IBaseDAL<MODEL.WF_BillFlowNode>
    {
    }

	public partial interface IWF_BillFlowNodeRemarkDAL : IBaseDAL<MODEL.WF_BillFlowNodeRemark>
    {
    }

	public partial interface IWF_BillStateDAL : IBaseDAL<MODEL.WF_BillState>
    {
    }

	public partial interface IWF_NodeDAL : IBaseDAL<MODEL.WF_Node>
    {
    }

	public partial interface IWF_NodeStateDAL : IBaseDAL<MODEL.WF_NodeState>
    {
    }

	public partial interface IWF_WorkFlowDAL : IBaseDAL<MODEL.WF_WorkFlow>
    {
    }

	public partial interface IWF_WorkFlowNodeDAL : IBaseDAL<MODEL.WF_WorkFlowNode>
    {
    }


}