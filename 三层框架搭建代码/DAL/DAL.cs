 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALMSSQL
{
	public partial class Bill_LeaveDAL : BaseDAL<MODEL.Bill_Leave>,IDAL.IBill_LeaveDAL
    {
    }
	public partial class Ou_DepartmentDAL : BaseDAL<MODEL.Ou_Department>,IDAL.IOu_DepartmentDAL
    {
    }
	public partial class Ou_PermissionDAL : BaseDAL<MODEL.Ou_Permission>,IDAL.IOu_PermissionDAL
    {
    }
	public partial class Ou_RoleDAL : BaseDAL<MODEL.Ou_Role>,IDAL.IOu_RoleDAL
    {
    }
	public partial class Ou_RolePermissionDAL : BaseDAL<MODEL.Ou_RolePermission>,IDAL.IOu_RolePermissionDAL
    {
    }
	public partial class Ou_UserInfoDAL : BaseDAL<MODEL.Ou_UserInfo>,IDAL.IOu_UserInfoDAL
    {
    }
	public partial class Ou_UserRoleDAL : BaseDAL<MODEL.Ou_UserRole>,IDAL.IOu_UserRoleDAL
    {
    }
	public partial class Ou_UserVipPermissionDAL : BaseDAL<MODEL.Ou_UserVipPermission>,IDAL.IOu_UserVipPermissionDAL
    {
    }
	public partial class WF_AutoTransactNodeDAL : BaseDAL<MODEL.WF_AutoTransactNode>,IDAL.IWF_AutoTransactNodeDAL
    {
    }
	public partial class WF_BillFlowNodeDAL : BaseDAL<MODEL.WF_BillFlowNode>,IDAL.IWF_BillFlowNodeDAL
    {
    }
	public partial class WF_BillFlowNodeRemarkDAL : BaseDAL<MODEL.WF_BillFlowNodeRemark>,IDAL.IWF_BillFlowNodeRemarkDAL
    {
    }
	public partial class WF_BillStateDAL : BaseDAL<MODEL.WF_BillState>,IDAL.IWF_BillStateDAL
    {
    }
	public partial class WF_NodeDAL : BaseDAL<MODEL.WF_Node>,IDAL.IWF_NodeDAL
    {
    }
	public partial class WF_NodeStateDAL : BaseDAL<MODEL.WF_NodeState>,IDAL.IWF_NodeStateDAL
    {
    }
	public partial class WF_WorkFlowDAL : BaseDAL<MODEL.WF_WorkFlow>,IDAL.IWF_WorkFlowDAL
    {
    }
	public partial class WF_WorkFlowNodeDAL : BaseDAL<MODEL.WF_WorkFlowNode>,IDAL.IWF_WorkFlowNodeDAL
    {
    }
}