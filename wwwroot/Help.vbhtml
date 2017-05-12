<!DOCTYPE html>
<html>
<head>
    <%= ./includes/head.vbhtml %>
    <?vb $title = "Help for GCModeller biostack platform" ?>
    <?vb $active3 = "active" ?>
</head>
<body>

    <div id="main-wrapper">

        <%= ./includes/navigation-bar.vbhtml %>

        <div class="row">
            <div class="small-12 columns">
                <h1>What is biostack platform?</h1>
                <p>
                    GCModeller Biostack is an open source cloud platform that focus on the biological network visualize, you can get all of the source code of the biostack cloud platform from <a href="https://github.com/GCModeller-Cloud/GCModeller-biostack/">Github/GCModeller-Cloud/</a>.
                    If you wish to help us add more function into GCModeller biostack cloud, then you can folk this repository, implements your own function using GCModeller and send us a pull request. if your PR is approved,
                    then it will be online soon.
                </p>
                <h2>Give us your advice?</h2>
                <form>
                    <p>
                        Your feedback is important to us, if you want to help GCModeller biostack to growing more better, please write to us in this form:
                    </p>
                    <textarea placeholder="Any good advice?" rows="12"></textarea>
                    <p>
                        If you would like a reply, please give us your email:
                    </p>
                    <input type="text"></input>
                    <button name="submit" onClick="">Send</button>
                </form>
            </div>
        </div>

        <%= ./includes/footer.vbhtml %>
    </div>
</body>
</html>
