<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="StyleSheet" href="css/ui-lightness/jquery-ui-1.9.2.custom.min.css" type="text/css" media="all" />
    <link rel="StyleSheet" href="css/jquery.tagedit.css" type="text/css" media="all" />
    <script src="js/biz.jquery.js"></script>

    <script type="text/javascript" src="js/jquery-ui-1.9.2.custom.min.js"></script>
    <script type="text/javascript" src="js/jquery.autoGrowInput.js"></script>
    <script type="text/javascript" src="js/jquery.tagedit.js"></script>
    <script type="text/javascript">
        $(function () {
            // Fullexample
            $("#tagform-full").find('input.tag').tagedit({
                autocompleteURL: 'ajax.aspx?action=getData',
                checkToDeleteURL: "ajax.aspx?action=deleteData",
                allowEdit: true,
                allowDelete: true,
                direction: "ltr",
                animSpeed: 500,
                texts: {
                    removeLinkTitle: '移除当前项.',
                    saveEditLinkTitle: '保存更改.',
                    deleteLinkTitle: '从数据库中删除该项.',
                    deleteConfirmation: '确实是否要删除该项?',
                    deletedElementTitle: '该项将被直接删除.',
                    breakEditLinkTitle: '取消'
                }
            });
        });
	</script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>tagedit 智能提示筛选DEMO </h2>
            <h4>author：peng8</h4>
            <span>
                请在下面的文本框中输入需要查询的信息!
            </span>
            <div id="tagform-full" style="margin:10px;">
                <input type="text" name="tag[]" value="" class="tag" id="txt_tag"  />
            </div>
            <div>
                <p>1、输入提示信息，模糊查询，Ajax异步从服务端获取检索结果</p>
                <p>2、检索结果可多选放置在文本框中</p>
            </div>
            <div>
               <h2>接口说明</h2>
                <ul>
                    <li>autocompleteURL: 智能提示请求的URL</li>
                    <li>checkToDeleteURL: 删除选项需要请求的URL</li>
                    <li>allowEdit: 是否允许编辑</li>
                    <li>allowDelete: 是否允许删除</li>
                    <li>animSpeed:加载速度</li>
                    <li>deletedPostfix:需要删除项的后缀</li>
                    <li>addedPostfix:需要增加项的后缀</li>
                </ul>
            </div>
        </div>
        <div style="padding:10px;border: 2px solid #808080">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <asp:Button runat="server" Text="提交到服务端" OnClick="save_Click"></asp:Button>
        
    </form>
</body>
</html>
