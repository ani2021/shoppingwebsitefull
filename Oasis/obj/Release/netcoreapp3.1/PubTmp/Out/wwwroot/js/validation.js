function ValidateRegistration()
{
  let pass = document.getElementById("password");
  let repass = document.getElementById("repassword");
  let email = document.getElementById("email");
  let reemail = document.getElementById("reemail").value;
  if(pass !== repass && email !== reemail)
  {
    console.log("Your fields do not match");
    return false;
  }
  return true;
}

function GeneralInputValidation()
{
  return true;
}

function ValidateItemsWizard()
{
  var quantityregex = "^[0-9]*$";
  var moneyregex = "[0-9]?[0-9]?(\.[0-9][0-9]?)?";
  var quantity = document.forms['itemwizard']['itemquantity'].value;
  var cost = document.forms['itemwizard']['itemprice'].value;
  var qr = quantity.search(quantityregex);
  var cr = cost.search(moneyregex);
  if(cr < 0 || qr < 0)
  {
    console.log('You have entered invalid parameters');
  }
  return true;
}
let w;
function SetSessionTimeout()
{
  /*console.log('Inside SetSessionTimeout()');
  w = window.setTimeout(function ()
  {
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("post", "Signout", true);
    xmlhttp.send();
    // window.location.reload(true);
  }, 2 * 1000);*/
}

function ResetSessionTimeout(session)
{
  /*console.log(session);*/
  if (w != null && session === true)
  {
    console.log('resetting session');
    window.clearTimeout(w);
    SetSessionTimeout();
  }
}