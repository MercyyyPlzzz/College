<html>
    <head>
        <title>
            Q6
        </title>
    </head>
    
    <body>
        <?php
        if(isset($_GET['percent']) )
        {
            $percent=$_GET['percent'];
            if($percent >= 40)
            {
                echo $percent." is a Pass";
            }
 else{
     echo "$percent is not a pass. You failed!";
 }
        }
        else{
        ?>
        <form id="form1" name="form1" method="get" action="">
            <p>
                <label for="percent">Enter Mark : </label>
                <input type="text" name="percent" id="percent" />
            </p>
          
            <p>
                <input type="submit" name="button" id="button" />
            </p>
        </form>
        <?php } ?>
        
        <br><a href="index.php">Return</a>
    </body>
</html>
