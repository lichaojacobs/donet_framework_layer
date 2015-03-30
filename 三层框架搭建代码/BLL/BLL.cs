 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLA
{
	public partial class Bill_Leave : BaseBLL<MODEL.Bill_Leave>,IBLL.IBill_LeaveBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IBill_LeaveDAL;
		}
    }
	public partial class Ou_Department : BaseBLL<MODEL.Ou_Department>,IBLL.IOu_DepartmentBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IOu_DepartmentDAL;
		}
    }
	public partial class Ou_Permission : BaseBLL<MODEL.Ou_Permission>,IBLL.IOu_PermissionBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IOu_PermissionDAL;
		}
    }
	public partial class Ou_Role : BaseBLL<MODEL.Ou_Role>,IBLL.IOu_RoleBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IOu_RoleDAL;
		}
    }
	public partial class Ou_RolePermission : BaseBLL<MODEL.Ou_RolePermission>,IBLL.IOu_RolePermissionBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IOu_RolePermissionDAL;
		}
    }
	public partial class Ou_UserInfo : BaseBLL<MODEL.Ou_UserInfo>,IBLL.IOu_UserInfoBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IOu_UserInfoDAL;
		}
    }
	public partial class Ou_UserRole : BaseBLL<MODEL.Ou_UserRole>,IBLL.IOu_UserRoleBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IOu_UserRoleDAL;
		}
    }
	public partial class Ou_UserVipPermission : BaseBLL<MODEL.Ou_UserVipPermission>,IBLL.IOu_UserVipPermissionBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IOu_UserVipPermissionDAL;
		}
    }
	public partial class WF_AutoTransactNode : BaseBLL<MODEL.WF_AutoTransactNode>,IBLL.IWF_AutoTransactNodeBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_AutoTransactNodeDAL;
		}
    }
	public partial class WF_BillFlowNode : BaseBLL<MODEL.WF_BillFlowNode>,IBLL.IWF_BillFlowNodeBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_BillFlowNodeDAL;
		}
    }
	public partial class WF_BillFlowNodeRemark : BaseBLL<MODEL.WF_BillFlowNodeRemark>,IBLL.IWF_BillFlowNodeRemarkBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_BillFlowNodeRemarkDAL;
		}
    }
	public partial class WF_BillState : BaseBLL<MODEL.WF_BillState>,IBLL.IWF_BillStateBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_BillStateDAL;
		}
    }
	public partial class WF_Node : BaseBLL<MODEL.WF_Node>,IBLL.IWF_NodeBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_NodeDAL;
		}
    }
	public partial class WF_NodeState : BaseBLL<MODEL.WF_NodeState>,IBLL.IWF_NodeStateBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_NodeStateDAL;
		}
    }
	public partial class WF_WorkFlow : BaseBLL<MODEL.WF_WorkFlow>,IBLL.IWF_WorkFlowBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_WorkFlowDAL;
		}
    }
	public partial class WF_WorkFlowNode : BaseBLL<MODEL.WF_WorkFlowNode>,IBLL.IWF_WorkFlowNodeBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IWF_WorkFlowNodeDAL;
		}
    }
}