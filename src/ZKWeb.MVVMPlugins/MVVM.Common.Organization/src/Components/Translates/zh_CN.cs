﻿using System.Collections.Generic;
using ZKWeb.MVVMPlugins.MVVM.Common.Base.src.Components.Translates.Bases;
using ZKWebStandard.Ioc;

namespace ZKWeb.MVVMPlugins.MVVM.Common.Organization.src.Components.Translates {
	/// <summary>
	/// 中文翻译
	/// </summary>
	[ExportMany]
	public class zh_CN : DictionaryTranslationProviderBase {
		/// <summary>
		/// 初始化
		/// </summary>
		public zh_CN() {
			Codes = new HashSet<string>() { "zh-CN" };
			Translates = new Dictionary<string, string>()
			{
				{ "Admin Login", "管理员登录" },
				{ "Tenant", "租户" },
				{ "Username", "用户名" },
				{ "Password", "密码" },
				{ "Captcha", "验证码" },
				{ "Default admin account is admin, password is 123456, please change it after login immediately",
					"默认管理员账号: admin, 密码: 123456, 登录后请尽快修改密码" },
				{ "Incorrect username or password", "用户名或密码错误" }

				// TODO: 缩减这里的翻译
				/* { "ZKWeb Default Website", "ZKWeb默认站点" },
				{ "Captcha", "验证码" },
				{ "Click to change captcha image", "点击更换验证码图片" },
				{ "Please enter captcha", "请填写验证码" },
				{ "Incorrect captcha", "验证码错误，请重新填写" },
				{ "{0} is required", "请填写{0}" },
				{ "Length of {0} must be {1}", "{0}的长度必须是{1}" },
				{ "Length of {0} must between {1} and {2}", "{0}的长度必须在{1}和{2}之间" },
				{ "HomePage", "首页" },
				{ "Index", "首页" },
				{ "Refresh", "刷新" },
				{ "Fullscreen", "全屏" },
				{ "Operations", "操作" },
				{ "Export to excel", "导出到表格" },
				{ "Print", "打印" },
				{ "Pagination Settings", "分页设置" },
				{ "[0] Records per page", "每页[0]条" },
				{ "Please enter keyword", "请填写关键词" },
				{ "Search", "搜索" },
				{ "AdvanceSearch", "高级搜索" },
				{ "Data with id {0} cannot be found", "无法找到Id是{0}的数据" },
				{ "True", "是" },
				{ "False", "否" },
				{ "Yes", "是" },
				{ "No", "否" },
				{ "Ok", "确认" },
				{ "Cancel", "取消" },
				{ "Actions", "操作" },
				{ "Deleted", "已删除" },
				{ "Select All", "全选" },
				{ "Select/Unselect All", "全选/取消全选" },
				{ "Submit", "提交" },
				{ "Please Select", "请选择" },
				{ "Only {0} files are allowed", "只允许上传{0}文件" },
				{ "Please upload file size not greater than {0}", "请上传大小不超过{0}的文件" },
				{ "Basic Information", "基本信息" },
				{ "Base Functions", "基础功能" },
				{ "Base functions and template pages", "基础的功能和模板页面" },
				{ "{0} format is incorrect", "{0}的格式不正确" },
				{ "Expand/Collapse All", "展开/折叠全部" },
				{ "Type", "类型" },
				{ "Menu", "菜单" },
				{ "BatchActions", "批量操作" },
				{ "FirstPage", "首页" },
				{ "PrevPage", "上一页" },
				{ "NextPage", "下一页" },
				{ "LastPage", "末页" },
				{ "Saved Successfully", "保存成功" },
				{ "WebsiteIndexPage", "网站首页" },
				{ "Copyright", "版权信息" },
				{ "IndexHelp", "首页帮助" },
				{ "Width", "宽度" },
				{ "Height", "高度" },
				{ "Example: 100px", "例如: 100px" },
				{ "Admin Login", "管理员登陆" },
				{ "Please enter username", "请填写用户名" },
				{ "Please enter password", "请填写密码" },
				{ "Username", "用户名" },
				{ "Password", "密码" },
				{ "Login", "登陆" },
				{ "Register new user", "注册新用户" },
				{ "RememberLogin", "记住登陆" },
				{ "Register", "注册" },
				{ "ConfirmPassword", "确认密码" },
				{ "Please repeat the password exactly", "请重复前面填写的密码" },
				{ "OldPassword", "原密码" },
				{ "Please enter old password", "请填写原密码" },
				{ "User Registration", "用户注册" },
				{ "User Login", "用户登录" },
				{ "Username is already taken, please choose other username", "用户名已经被使用，请选择其他用户名" },
				{ "You have registered successfully, thanks for you registration", "注册用户成功，感谢您的注册" },
				{ "User Panel", "用户中心" },
				{ "Login successful", "登陆成功" },
				{ "Welcome to ", "欢迎光临" },
				{ "Logout", "退出登陆" },
				{ "Register for free", "免费注册" },
				{ "Website has no admin yet, the first login user will become super admin.",
					"当前没有任何管理员，第一次登录的用户将会成为超级管理员" },
				{ "You have already logged in, continue will replace the logged in user.",
					"您已经登陆，继续登陆将会替换当前登录的用户" },
				{ "Sorry, You have no privileges to use admin panel.", "抱歉，你没有使用管理后台的权限" },
				{ "Incorrect username or password", "用户名或密码不正确，请重新填写" },
				{ "Apps", "应用" },
				{ "Workspace", "工作间" },
				{ "Website Index", "网站首页" },
				{ "About Me", "关于我" },
				{ "About Website", "关于网站" },
				{ "Admin Panel", "管理后台" },
				{ "My Apps", "我的应用" },
				{ "Action require {0}, and {1} privileges", "操作要求拥有{0}身份，且拥有{1}权限" },
				{ "Action require {0}", "操作要求拥有{0}身份" },
				{ "User", "用户" },
				{ "UserType", "用户类型" },
				{ "Admin", "管理员" },
				{ "SuperAdmin", "超级管理员" },
				{ "CooperationPartner", "合作伙伴" },
				{ "CreateTime", "创建时间" },
				{ "Admin Manage", "管理员管理" },
				{ "User Manage", "用户管理" },
				{ "Role Manage", "角色管理" },
				{ "Role", "角色" },
				{ "Roles", "角色" },
				{ "UserRole", "角色" },
				{ "View", "查看" },
				{ "Edit", "编辑" },
				{ "Delete", "删除" },
				{ "DeleteForever", "永久删除" },
				{ "Please enter name", "请填写名称" },
				{ "Remark", "备注" },
				{ "Please enter remark", "请填写备注" },
				{ "Keep empty if you don't want to change", "如果不想修改，请保持空白" },
				{ "Name/Remark", "名称/备注" },
				{ "Name", "名称" },
				{ "Value", "值" },
				{ "DirectoryName", "目录名称" },
				{ "Description", "描述" },
				{ "UpdateTime", "更新时间" },
				{ "Add {0}", "添加{0}" },
				{ "Edit {0}", "编辑{0}" },
				{ "Delete {0}", "删除{0}" },
				{ "Please enter password when creating admin", "创建管理员时需要填写密码" },
				{ "Please enter password when creating user", "创建用户时需要填写密码" },
				{ "You can't downgrade yourself to normal admin", "不能取消自身的超级管理员权限" },
				{ "Privileges", "权限" },
				{ "Recycle Bin", "回收站" },
				{ "Batch Delete", "批量删除" },
				{ "Please select {0} to delete", "请选择需要删除的{0}" },
				{ "Sure to delete following {0}?", "确认删除以下{0}？" },
				{ "Batch Recover", "批量恢复" },
				{ "Please select {0} to recover", "请选择需要恢复的{0}" },
				{ "Sure to recover following {0}?", "确认恢复以下{0}？" },
				{ "Batch Delete Forever", "批量永久删除" },
				{ "Sure to delete following {0} forever?", "确认永久删除以下{0}？此操作将不可恢复！" },
				{ "Delete yourself is not allowed", "不能删除你自身的用户" },
				{ "Action {0} not exist", "找不到{0}对应的操作" },
				{ "Delete Successful", "删除成功" },
				{ "Batch Delete Successful", "批量删除成功" },
				{ "Batch Recover Successful", "批量恢复成功" },
				{ "Batch Delete Forever Successful", "批量永久删除成功" },
				{ "Change Password", "修改密码" },
				{ "Change Avatar", "修改头像" },
				{ "Avatar", "头像" },
				{ "DeleteAvatar", "删除头像" },
				{ "Please select avatar file", "请选择头像图片" },
				{ "Parse uploaded image failed", "解析上传的图片失败" },
				{ "User not found", "用户不存在" },
				{ "Incorrect old password", "原密码不正确，请重新填写" },
				{ "No Role", "无角色" },
				{ "Website Name", "网站名称" },
				{ "Default Language", "默认语言" },
				{ "Default Timezone", "默认时区" },
				{ "Hosting Information", "服务器信息" },
				{ "Plugin List", "插件列表" },
				{ "Admin panel and users management", "提供管理后台和用户角色管理等功能" },
				{ "Clear Cache", "清理缓存" },
				{ "Clear Cache Successfully", "清理缓存成功" },
				{ "Server Username", "服务器用户" },
				{ "Version", "版本" },
				{ "FullVersion", "完整版本" },
				{ "ZKWeb Version", "ZKWeb版本" },
				{ "ZKWeb Full Version", "ZKWeb完整版本" },
				{ "Memory Usage", "使用内存" },
				{ "Action require the ownership of {0}: {1}", "操作需要拥有以下{0}的所有权: {1}" },
				{ "Action require the tenant ownership of {0}: {1}", "操作需要拥有以下{0}的租户所有权: {1}" },
				{ "System Manage", "系统管理" },
				{ "Other", "其它" },
				{ "Toggle navigation", "切换导航栏" },
				{ "Recover", "恢复" },
				{ "Delete Forever", "永久删除" },
				{ "Recover {0}", "恢复{0}" },
				{ "Delete {0} Forever", "永久删除{0}" },
				{ "Add", "添加" },
				{ "Return To List", "返回列表" },
				{ "AdminIndexPage", "后台首页" },
				{ "AdminLoginPage", "后台登陆页" },
				{ "AdminAboutMePage", "后台关于我页" },
				{ "AdminAboutWebsitePage", "后台关于网站页" },
				{ "UserRegPage", "用户注册页" },
				{ "UserLoginPage", "用户登录页" },
				{ "UserIndexPage", "用户中心页" },
				{ "AdminSidebarAppMenu", "后台侧边栏程序菜单" },
				{ "EnterAdminPanel", "进入后台" },
				{ "UserLoginInfo", "登录信息" },
				*/
			};
		}
	}
}
