/*

// Current progress phase is phase2
{
"current": 1,
"progress": ["phase1", "phase2", "phase3"]
}

*/

function showProgress(div, url) {

var node = document.getElementByID(div);
var ul = document.createElement("ul");

$.getJSON( url, function( data ) {
  
  var current = data.current;
  
  data.progress.forEach(function(name, i) {
  
    var progress = document.createElement("li");
  
    if ( i == current) {
       // 字体加粗表示当前在执行的任务
       progress.html = "<strong>" + name + "</strong>";
    } else {
      // 字体使用灰色，表示已经执行完毕或者还没有执行的任务
      progress.html = name;
      progress.style = "color:grey";
    }
  
    ul.append(progress);
  
  });
});

}