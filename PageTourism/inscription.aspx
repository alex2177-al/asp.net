<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscription.aspx.cs" Inherits="PageTourism.inscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <h1>Inscription</h1>
    </div>
    <div id="main">
        <form id="form1" runat="server">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Email</label>
                    <asp:TextBox ID="TxtTo2" runat="server"></asp:TextBox>
                </div>
                
            </div>
            <div class="form-group">
                <label for="inputAddress">Address</label>
                <input type="text" class="form-control" id="inputAddress" placeholder="1234 Main St"/>
            </div>
         
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputCity">City</label>
                    <input type="text" class="form-control" id="inputCity"/>
                </div>
                <div class="form-group col-md-4">
                    <label for="inputState">Province/Territoire</label>
                    <select id="inputState" class="form-control">
                        <option selected>Choose...</option>
                        <option>Quebec</option>
                        <option>Alberta</option>
                        <option>Colombie-Britannique</option>
                        <option>Ile-du-Prince-Edouard</option>
                        <option>Manitoba</option>
                        <option>Nouveau-Brunswisk</option>
                        <option>Nouvelle-Ecosse</option>
                        <option>Ontario</option>
                        <option>Saskatchewan</option>
                        <option>Terre-neuve-et-Labrador</option>
                        <option>Yukon</option>
                        <option>Territoires du Nord-Ouest</option>
                        <option>Nunavut</option>

                    </select>
                </div>
                <div class="form-group col-md-2">
                    <label for="inputZip">Postal Code</label>
                    <input type="text" class="form-control" id="inputZip"/>
                </div>
            </div>
           
            <asp:Button ID="btnInsc" runat="server" OnClick="btnInscription" Text="Sign me up" />
        </form>
    </div>
</body>
</html>


