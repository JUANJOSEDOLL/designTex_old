<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="EShop.User.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




         <h4>Detalle de Producto</h4>

     <div class="container">
         <div class="row">
  <div class="col-sm-9 " style="background-color:blue">   <asp:Image ID="photoImage" runat="server" /></div>
  <div class="col-sm-3" style="background-color:aquamarine">
    
   <div class="form-group">
        <asp:Label ID="Label5" runat="server" Text="Label">Artículo: </asp:Label>
        <asp:Label ID="txtProductName" runat="server" Text="Label" Font-Bold="true"></asp:Label>
    </div>
        <div class="form-group">
        <asp:Label ID="Label3" runat="server" Text="Label" >Precio: </asp:Label>
        <asp:Label ID="txtProductPrice" runat="server" Text="Label" Font-Bold="true" ></asp:Label>
    </div>
    <div class="form-group">
        <asp:Label ID="Label4" runat="server" Text="Label">Categoría:</asp:Label>
        <asp:Label ID="txtCategory" runat="server" Text="Label" Font-Bold="true"></asp:Label>
        
    </div>
    <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="Label">Disponemos de </asp:Label>
    
        <asp:Label ID="txtStock" runat="server" Text="Label" Font-Bold="true"></asp:Label>
        </div>
    
 

        <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="true">Descripción: </asp:Label>
        <asp:Label ID="txtProductDescription" runat="server" Text="Label"></asp:Label>
 

    </div>
       
   
      </div>
 
</div>


          



   

  
            </div>



          


       



             


</asp:Content>
