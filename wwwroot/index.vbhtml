﻿<!DOCTYPE html>
<html>
<head>
	<%= ./includes/head.vbhtml %>
	<?vb $title = "Welcome to the GCModeller biostack platform" ?>
	<?vb $active1 = "active" ?>
</head>
<body>

	<div id="main-wrapper">
    
		<%= ./includes/navigation-bar.vbhtml %>
    
		<div class="row">
			<div class="small-12 columns">
				<iframe width=1024 height=840 frameborder="no" border="0" marginwidth="0" marginheight="0" scrolling="no" allowtransparency="yes" src="./FeatureTools.vbhtml"></iframe>
			</div>
		</div>
	
		<div class="row">
			<div class="small-12 columns">
				<h1>Biostack platform</h1>
				<h3>Navigate reference database</h3>
				<ul>
					<li><a href="./KEGG.vbhtml"><%= @KEGG %></a></li>
					<li><a href="./Uniprot.vbhtml"><%= @Uniprot %></a></li>
					<li><a href="./RegPrecise.vbhtml"><%= @RegPrecise %></a></li>
				</ul>
			</div>
		</div>
    
		<%= ./includes/footer.vbhtml %>

	</div>
	
</body>
</html>
