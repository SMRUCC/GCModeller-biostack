
function d3Network(jsonFile, width, height,  nodeMin = 6, d3color = true) {
	    
    var force = d3.layout.force()
          .charge(-100)
    .linkDistance(20)
        .gravity(0.25)
        .size([width, height]);

    var svg = d3.select("body").append("svg")		
        .attr("width", width)
        .attr("height", height)
		.attr("class", "chart");
    
    d3.json(jsonFile, function (error, graph) {
        if (error) throw error;
		
		console.log(graph);
		
        force
            .nodes(graph.nodes)
            .links(graph.links)
            .start();

		var color = d3.scale.category10();
	
        var link = svg.selectAll(".link")
            .data(graph.links)
            .enter().append("line")
            .attr("class", "link")
            .style("stroke-width", function(l) {
				return 2;
			});

		// Create the groups under svg
var nodes = svg.selectAll('g.gnode')
  .data(graph.nodes)
  .enter()
  .append('g')
  .classed('node', true);
  
  var getColor = function(d) {
	 if (!d3color && d.color != null) {
		return d.color;
	 } else {
		return color(d.group);
	 }
  }

// Add one circle in each group
var node = nodes.append("circle")
  .attr("class", "node")
  .attr("r", function (d) {
                 if(d.size>=0){
        return nodeMin + Math.pow(d.size, 1/(2.7));
      }
      return nodeMin;
            })
            .style("fill", getColor)
            .style("opacity", 1)
            .call(force.drag);
			
var texts = svg.selectAll("text.label")
                .data(graph.nodes)
                .enter().append("text")
                .attr("class", "label")
				.attr("font-family", "Microsoft YaHei")
                .attr("fill", getColor)
				.attr("font-size", function(d) {
					var size = d.size / 2;
					var min = 3;
					
					if (size < min) {
						size = min;
					}
					return size + "px";
				})
                .text(function(d) {  return d.name;  });
			        
        force.on("tick", function () {
            link.attr("x1", function (d) { return d.source.x; })
                .attr("y1", function (d) { return d.source.y; })
                .attr("x2", function (d) { return d.target.x; })
                .attr("y2", function (d) { return d.target.y; });

            node.attr("cx", function (d) { return d.x; })
                .attr("cy", function (d) { return d.y; });
				
				 texts.attr("transform", function(d) {
        return "translate(" + d.x + "," + d.y + ")";
    });
        });
    });
}