using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using Shopping_Cart.Logic;

namespace Shopping_Cart
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProductID"];
            int productID;
            if(!String.IsNullOrEmpty(rawId) && int.TryParse(rawId,out productID))
            {
                using (ShoppingCartActions shoppingCartActions = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We Should never get to AddToCart.aspx without a ProductId.");
                throw new Exception("ERROR : We Should never get to AddToCart.aspx without a ProductId.");
            }
            Response.Redirect("ShoppingCart.aspx);
        }
    }
}