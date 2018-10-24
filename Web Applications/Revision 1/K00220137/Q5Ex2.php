<html>
    <head>
        <title>
            Q6
        </title>
    </head>
    
    <body>
        <?php
        if(isset($_GET['words']) )
        {
            $words=$_GET['words'];
           $eol = "\n";
$turned = function($words) use ($eol) {
    $length = max(array_map('strlen', $lines = explode($eol, trim($words))));
    $each = function($a, $s) use ($length) {$a[] = str_split(sprintf("%' {$length}s", $s)); return $a;};
    return implode($eol, array_map(function($v) {return implode(' ', $v);}, call_user_func_array('array_map',
        array_reduce($lines, $each, array(NULL)))));
};

echo $turned($words), $eol;
        }
        else{
        ?>
        <form id="form1" name="form1" method="get" action="">
            <p>
                <label for="words">Enter string : </label>
                <input type="text" name="words" id="words" />
            </p>
          
            <p>
                <input type="submit" name="button" id="button" />
            </p>
        </form>
        <?php } ?>
        
        <br><a href="index.php">Return</a>
    </body>
</html>

