<html>
    <head>
        <title>
            Q6
        </title>
    </head>
    
    <body>
        <?php
        if(isset($_POST['number']))
        ?>
        <form id="form1" name="form1" method="get" action="">
            <p>
                <label for="number">Enter Mark : </label>
                <input type="text" name="number" id="number" />
            </p>
          
            <p>
                <input type="submit" name="button" id="button" />
            </p>
        </form>
        <br><a href="index.php">Return</a>
    </body>
</html>