function ShowMenu()
{
  document.getElementById("dropdownmenu").classList.add("dropdown");
}

function PopupToggle(name)
{
  let item = document.getElementById(name);
  
  if(item.style.display === "block")
  {
    item.style.display = "none";
  }
  else
  {
    item.style.display = "block";
  }
}

function HideForm(name, formname)
{
  let item = document.getElementById(name);
  let form = document.getElementById(formname);
  item.style.display = "none";
  form.reset();
}

function ShowOptions(options, decision='yes')
{
  let d = document.getElementById(options);
  if(decision === 'no')
  {
    d.style.display = "none";
  }
  else
  {
    d.style.display = "block";
  }
}

function DisplayGraphOptions(option)
{
  let decision = option.value;
  let dates = document.getElementById('dates');
  let form = document.forms.graphsetup;
  let start = form.elements.start;
  let end = form.elements.end;
  if (decision === 'yes')
  {
    dates.style.display = "block";
    start.required = true;
    end.required = true;
  }
  else if(decision === 'no')
  {
    dates.style.display = "none";
    start.required = false;
    end.required = false;
	}
}

function SelectItem(option)
{
  option.style.display = "none";
  let selected = document.getElementById('selectedItems');
  let hasChild = selected.hasChildNodes();
  let displayOption = document.createElement('label');
  let val = document.getElementById("items");
  if(hasChild == false)
  {
    displayOption.style.marginLeft = "20px";
  }
  else
  {
    displayOption.style.marginLeft = "5px";
  }
  displayOption.textContent = option.value;
  val.value += option.value + ",";
  displayOption.addEventListener("click", DeselectItem, false);
  displayOption.setAttribute("id", option.value);
  selected.appendChild(displayOption);
  document.getElementById('itemOptions').selectedIndex = 0;
}

function DeselectItem()
{
  let val = document.getElementById("items");
  let container = document.getElementById('selectedItems');
  let option = document.getElementsByName(this.textContent)[0];
  val.value = val.value.replace(option.textContent+",", "");
  container.removeChild(this);
  option.style.display = "block";
}

function Selected(list)
{
  let lst = document.getElementsByName("listname");
  for(let x = 0; x < lst.length; x++)
  {
    lst[x].style.color = "inherit";
  }
  list.style.color = "red";
}