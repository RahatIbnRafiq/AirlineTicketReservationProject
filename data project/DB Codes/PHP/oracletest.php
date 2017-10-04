<?php	
		  include_once('config.php');
		  $db = oci_connect(ORAUSER,ORAPASS,ORADB);			  
		  $sql="select bookid,title from lib_book"; 
		  $result=oci_parse($db,$sql);			                             		                              
		  oci_execute($result);		
		  while($row = oci_fetch_array($result))
		  {			
			  echo "BookId : ".$row['BOOKID'];
			  echo " Title : ".$row['TITLE']."<br>";			  
		  }		 		  
		  oci_free_statement($result);
		  oci_close($db);
?>