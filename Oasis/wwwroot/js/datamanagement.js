function AddToList(lst, itm)
{
  var xmlhttp = new XMLHttpRequest();
  xmlhttp.open("post", "AddToList?lst=" + lst + "&itm=" + itm, true);
  xmlhttp.send();
}

function GetQuantity()
{
  let qty = document.getElementById('qty');
  if(localStorage.getItem('quantity') == null)
  {
    qty.value = 1;
  }
  qty.value = localStorage.getItem('quantity');
}