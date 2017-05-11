<!DOCTYPE html>
<html>
<head>
	<%= ../includes/head.vbhtml %>
	<%= ../includes/breadcrumb/styles.vbhtml %>
	<%= ../includes/tab/styles.vbhtml %>
	
	<?vb $title = "KEGG reference navigation" ?>
	<?vb $active2 = "active" ?>
</head>
<body>

	<div id="main-wrapper">
    
		<%= ./includes/navigation-bar.vbhtml %>
    
		<div class="row">
			<div class="small-12 columns">
		<br />		
			
			<h2><%= @KEGG %></h2>
    
			<%= ./includes/tab/kegg.vbhtml %>
			<%= ./includes/breadcrumb/kegg.vbhtml %>
			
			</div>
		</div>
	
		<%= ./includes/footer.vbhtml %>

	</div>
		
</body>
</html>