function userinfo($this,styleid){
	$this.className=($this.className=="top_userinfoa"?"top_userinfoas":"top_userinfoa");
	
	var styleul = document.getElementById(styleid);
	if(styleul.style.display=="none"){
		document.getElementById('pub_left').className='clickleft';
		styleul.style.display="block";
	}else{
		document.getElementById('pub_left').className='left';
		styleul.style.display="none";
	}
}