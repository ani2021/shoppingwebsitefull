function DisplayGraphs(data, cn)
{
  if (data !== null)
  {
    let arrdata = [];
    let arrlabels = [];
    for (let i = 0; i < data.items.length; i++)
    {
      if(data.parameter === 'Rating')
      {
        arrdata.push(data.items[i].item.averageRating);
      }
      else if(data.parameter === 'Average Rating' || data.parameter === 'Inventory')
      {
        arrdata.push(data.items[i].count);
			}      
      arrlabels.push(data.items[i].item.name);
    }
    var ctx = document.getElementById(cn).getContext('2d');
    var myChart = new Chart(ctx, {
      type: data.graphType,
      data: {
        labels: arrlabels,
        datasets: [{
          label: data.graphName,
          data: arrdata,
          borderWidth: 1
        }]
      },
      options: {
        scales: {
          yAxes: [{
            ticks: {
              beginAtZero: true
            }
          }]
        },
        title: {
          text: data.graphName
        }
      }
    });
  }
}
/*var ctx = document.getElementById('myChart2').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'pie',
    data: {
        labels: ['Xbox One', 'PS5', 'N64', 'Screws', 'Wrench'],
        datasets: [{
            label: 'Revenue',
            data: [350000, 400000, 50000, 22000, 11150],
            backgroundColor: [
              'rgba(255, 99, 132, 0.2)',
              'rgba(54, 162, 235, 0.2)',
              'rgba(255, 206, 86, 0.2)',
              'rgba(75, 192, 192, 0.2)',
              'rgba(153, 102, 255, 0.2)',
              'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
      title: {
          display: true,
          text: 'Revenue'
      }
  }
});

var ctx = document.getElementById('myChart3').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May'],
        datasets: [{
            label: 'Xbox Revenue',
            data: [150, 200, 50, 600, 550],
        }]
    },
    options: {
      title: {
          display: true,
          text: 'Xbox Revenue'
      }
  }
});

var ctx = document.getElementById('myChart4').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May'],
        datasets: [{
            label: 'PS5 Revenue',
            data: [500, 250, 210, 450, 550],
        }]
    },
    options: {
      title: {
          display: true,
          text: 'PS5 Revenue'
      }
  }
});*/