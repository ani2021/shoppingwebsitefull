function AddToList(lst, itm)
{
  var xmlhttp = new XMLHttpRequest();
  xmlhttp.open("post", "AddToList?lst=" + lst + "&itm=" + itm, true);
  xmlhttp.send();
}

function Purchase()
{
  console.log("Purchase() method");
  var item = document.getElementById('listname').value;
  var quantity = document.getElementById('quantity').value;
  console.log(quantity);
  /*var xmlhttp = new XMLHttpRequest();
  xmlhttp.open("post", "Purchase?item=" + item + "&quantity=" + quantity, true);
  xmlhttp.send();*/
}

/*function RetrieveListItems(lst)
{
  let name = lst.textContent;
  var xmlhttp = new XMLHttpRequest();
  xmlhttp.open("post", "RetrieveList?lst=" + name, true);
  xmlhttp.send();
}*/