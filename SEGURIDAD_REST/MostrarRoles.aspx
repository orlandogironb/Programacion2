<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MostrarRoles.aspx.cs" Inherits="MostrarRoles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsRoles" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="COD_ROL" HeaderText="COD_ROL" SortExpression="COD_ROL" />
                <asp:BoundField DataField="NOM_ROL" HeaderText="NOM_ROL" SortExpression="NOM_ROL" />
                <asp:TemplateField>
                    <ItemTemplate>
                       <asp:HyperLink runat="server" NavigateUrl='<%# "~/MantoRoles.aspx?COD_ROL="+Eval("COD_ROL") %>'>
                           Editar
                       </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEliminar" runat="server" CommandArgument='<%#Eval("COD_ROL")%>' OnClick="btnEliminar_Click">Eliminar</asp:LinkButton>
                    </ItemTemplate>

                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsRoles" runat="server" SelectMethod="MostrarTodosRoles" TypeName="RollBLL"></asp:ObjectDataSource>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
