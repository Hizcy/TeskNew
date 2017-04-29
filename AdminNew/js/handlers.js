function fileQueueError(file, errorCode, message) {
	try {
		var imageName = "error.gif";
		var errorName = "";
		if (errorCode === SWFUpload.errorCode_QUEUE_LIMIT_EXCEEDED) {
			errorName = "You have attempted to queue too many files.";
		}

		if (errorName !== "") {
			alert(errorName);
			return;
		}

		switch (errorCode) {
		case SWFUpload.QUEUE_ERROR.ZERO_BYTE_FILE:
			imageName = "zerobyte.gif";
			break;
		case SWFUpload.QUEUE_ERROR.FILE_EXCEEDS_SIZE_LIMIT:
			imageName = "toobig.gif";
			break;
		case SWFUpload.QUEUE_ERROR.ZERO_BYTE_FILE:
		case SWFUpload.QUEUE_ERROR.INVALID_FILETYPE:
		default:
			alert(message);
			break;
		}

		addImage("images/" + imageName);

	} catch (ex) {
		this.debug(ex);
	}

}

function fileDialogComplete(numFilesSelected, numFilesQueued) {
    try {
        //alert("2:" + postobj);
        if (numFilesQueued > 0) {
          
            this.setPostParams({ "imgid": postobj });
			this.startUpload();
		}
	} catch (ex) {
		this.debug(ex);
	}
}

function uploadProgress(file, bytesLoaded) {

    try {
        //alert();
		var percent = Math.ceil((bytesLoaded / file.size) * 100);

		var progress = new FileProgress(file,  this.customSettings.upload_target);
		progress.setProgress(percent);
		if (percent === 100) {
			//progress.setStatus("Creating thumbnail...");
			progress.toggleCancel(false, this);
		} else {
			//progress.setStatus("Uploading...");
			progress.toggleCancel(true, this);
		}
	} catch (ex) {
		this.debug(ex);
	}
}

function uploadSuccess(file, serverData) {
    try {
        //alert(112233);
        //var arr = serverData.split("|");
        //alert(arr)
        //alert(document.getElementById('hid').value);
        //if (arr[1] == "0") {
        //    document.getElementById('hid').value = arr[1];
        //}
        //else if (arr[1] == "1") {
        //    document.getElementById('ctl00_ContentPlaceHolder1_hid').value += "," + arr[1];
        //}
        //else if (arr[1] == "2") {
        //    $("#d0").find(".hid_material_img").html(arr[0]);
        //}
        //else {
        //    $("#" + arr[1]).find(".hid_material_img").html(arr[0]);
        //}
        //salert(arr[0]);
        //addImage("../Data/data.aspx?type=upload&path=" + arr[0]);
        
        //if (arr[1] == "0") {
      
        //    addImage(arr[0]);
        
        //}
       //if (arr[2] == "1") {
       //     addImage(arr[0]);
       // }
       // else if (arr[2] == "2") {

       //     addImage(arr[0]);

        
       // }
        //else {
        //    addImage(arr[0]);
        
        //}
        //var progress = new FileProgress(file,  this.customSettings.upload_target);

		////progress.setStatus("Thumbnail Created.");
		//progress.toggleCancel(false);
        
        var arr = serverData.split("|");
       
      
            addImage(arr[0], arr[2],arr[3]);
        
        
        

        var progress = new FileProgress(file, this.customSettings.upload_target);
        progress.toggleCancel(false);
	} catch (ex) {
		this.debug(ex);
	}
}

function uploadComplete(file) {
    try {
        //alert(11);
		/*  I want the next upload to continue automatically so I'll call startUpload here */
		if (this.getStats().files_queued > 0) {
			this.startUpload();
		} else {
			var progress = new FileProgress(file,  this.customSettings.upload_target);
			progress.setComplete();
			//progress.setStatus("All images received.");
			progress.toggleCancel(false);
		}
	} catch (ex) {
		this.debug(ex);
	}
}

function uploadError(file, errorCode, message) {
    //alert(22);
	var imageName =  "error.gif";
	var progress;
	try {
		switch (errorCode) {
		case SWFUpload.UPLOAD_ERROR.FILE_CANCELLED:
			try {
				progress = new FileProgress(file,  this.customSettings.upload_target);
				progress.setCancelled();
				//progress.setStatus("Cancelled");
				progress.toggleCancel(false);
			}
			catch (ex1) {
				this.debug(ex1);
			}
			break;
		case SWFUpload.UPLOAD_ERROR.UPLOAD_STOPPED:
			try {
				progress = new FileProgress(file,  this.customSettings.upload_target);
				progress.setCancelled();
				//progress.setStatus("Stopped");
				progress.toggleCancel(true);
			}
			catch (ex2) {
				this.debug(ex2);
			}
		case SWFUpload.UPLOAD_ERROR.UPLOAD_LIMIT_EXCEEDED:
			imageName = "uploadlimit.gif";
			break;
		default:
			alert(message);
			break;
		}

		addImage("images/" + imageName);

	} catch (ex3) {
		this.debug(ex3);
	}

}
function delImage(id)
{
    
    //var id = parseInt($("#hid").val());
    var str = $("#hid").val();
    //var arr = id.split("_");
    if (str.indexOf(id + ",") >= 0) {
        $("#hid" + id).val("");
        $("#image_" + id + " img").remove();
        var newImg = document.createElement("img");
        newImg.style.width = "50px";
        newImg.style.height = "50px";
        newImg.src = "../image/tianjiatupian.png";
        document.getElementById("image_" + id).appendChild(newImg);
        str = str.replace(id + ",", "");
        $("#hid").val(str);
    }
    
}

function addImage(src, id, imgid) {

    if (id == "1") {
        document.getElementById("imgdel1").src = src;
        $("#hid1").val(src);
    }
    else if (id == "2") {
        if (imgid == 0)
        {
            document.getElementById("imgdel2").src = src;
            $("#hid2").val(src);
        }
        else
        {
            document.getElementById("imgdel4").src = src;
            $("#hid2").val(src);
        }
       
    }
    else if (id == "3") {
        document.getElementById("imgdel3").src = src;
        $("#hid3").val(src);
    }
    var newImg = document.createElement("img");
    newImg.style.margin = "1px";


	if (newImg.filters) {
		try {
			newImg.filters.item("DXImageTransform.Microsoft.Alpha").opacity = 0;
		} catch (e) {
			// If it is not set initially, the browser will throw an error.  This will set it if it is not set yet.
			newImg.style.filter = 'progid:DXImageTransform.Microsoft.Alpha(opacity=' + 0 + ')';
		}
	} else {
		newImg.style.opacity = 0;
	}

}
//function addImage1(src) {
//    var newImg = document.createElement("img");
    
//    var material_default = document.getElementById("material_item_default");
//    material_default.style.display = "none";
//    document.getElementById("material_item_thum").appendChild(newImg);

//    if (newImg.filters) {
//        try {
//            newImg.filters.item("DXImageTransform.Microsoft.Alpha").opacity = 0;
//        } catch (e) {
//            // If it is not set initially, the browser will throw an error.  This will set it if it is not set yet.
//            newImg.style.filter = 'progid:DXImageTransform.Microsoft.Alpha(opacity=' + 0 + ')';
//        }
//    } else {
//        newImg.style.opacity = 0;
//    }

//    newImg.onload = function () {
//        fadeIn(newImg, 0);
//    };
//    newImg.src = src;
//    newImg.width = 265;
//    newImg.height = 160;
//}

//function addImage3(src,id) {
//    var newImg = document.createElement("img");

//    var material_default = $("#" + id).find(".img_default");
//    material_default.css("display", "none");
//    //alert($("#" + id).find(".material_item_default").html());
//    $("#" + id).find(".material_item_default").append(newImg);

//    if (newImg.filters) {
//        try {
//            newImg.filters.item("DXImageTransform.Microsoft.Alpha").opacity = 0;
//        } catch (e) {
//            // If it is not set initially, the browser will throw an error.  This will set it if it is not set yet.
//            newImg.style.filter = 'progid:DXImageTransform.Microsoft.Alpha(opacity=' + 0 + ')';
//        }
//    } else {
//        newImg.style.opacity = 0;
//    }

//    newImg.onload = function () {
//        fadeIn(newImg, 0);
//    };
//    newImg.src = src;
//    newImg.width = 80;
//    newImg.height = 80;
//}
function fadeIn(element, opacity) {
	var reduceOpacityBy = 5;
	var rate = 30;	// 15 fps


	if (opacity < 100) {
		opacity += reduceOpacityBy;
		if (opacity > 100) {
			opacity = 100;
		}

		if (element.filters) {
			try {
				element.filters.item("DXImageTransform.Microsoft.Alpha").opacity = opacity;
			} catch (e) {
				// If it is not set initially, the browser will throw an error.  This will set it if it is not set yet.
				element.style.filter = 'progid:DXImageTransform.Microsoft.Alpha(opacity=' + opacity + ')';
			}
		} else {
			element.style.opacity = opacity / 100;
		}
	}

	if (opacity < 100) {
		setTimeout(function () {
			fadeIn(element, opacity);
		}, rate);
	}
}



/* ******************************************
 *	FileProgress Object
 *	Control object for displaying file info
 * ****************************************** */

function FileProgress(file, targetID) {
	this.fileProgressID = "divFileProgress";

	this.fileProgressWrapper = document.getElementById(this.fileProgressID);
	if (!this.fileProgressWrapper) {
		this.fileProgressWrapper = document.createElement("div");
		this.fileProgressWrapper.className = "progressWrapper";
		this.fileProgressWrapper.id = this.fileProgressID;

		this.fileProgressElement = document.createElement("div");
		this.fileProgressElement.className = "progressContainer";

		var progressCancel = document.createElement("a");
		progressCancel.className = "progressCancel";
		progressCancel.href = "#";
		progressCancel.style.visibility = "hidden";
		progressCancel.appendChild(document.createTextNode(" "));

		var progressText = document.createElement("div");
		progressText.className = "progressName";
		//progressText.appendChild(document.createTextNode(file.name));

		var progressBar = document.createElement("div");
		progressBar.className = "progressBarInProgress";

		var progressStatus = document.createElement("div");
		progressStatus.className = "progressBarStatus";
		//progressStatus.innerHTML = "&nbsp;";

		this.fileProgressElement.appendChild(progressCancel);
		this.fileProgressElement.appendChild(progressText);
		this.fileProgressElement.appendChild(progressStatus);
		this.fileProgressElement.appendChild(progressBar);

		this.fileProgressWrapper.appendChild(this.fileProgressElement);

		document.getElementById(targetID).appendChild(this.fileProgressWrapper);
		fadeIn(this.fileProgressWrapper, 0);

	} else {
		this.fileProgressElement = this.fileProgressWrapper.firstChild;
		this.fileProgressElement.childNodes[1].firstChild.nodeValue = file.name;
	}

	this.height = this.fileProgressWrapper.offsetHeight;

}
FileProgress.prototype.setProgress = function (percentage) {
	this.fileProgressElement.className = "progressContainer green";
	this.fileProgressElement.childNodes[3].className = "progressBarInProgress";
	this.fileProgressElement.childNodes[3].style.width = percentage + "%";
};
FileProgress.prototype.setComplete = function () {
	this.fileProgressElement.className = "progressContainer blue";
	this.fileProgressElement.childNodes[3].className = "progressBarComplete";
	this.fileProgressElement.childNodes[3].style.width = "";

};
FileProgress.prototype.setError = function () {
	this.fileProgressElement.className = "progressContainer red";
	this.fileProgressElement.childNodes[3].className = "progressBarError";
	this.fileProgressElement.childNodes[3].style.width = "";

};
FileProgress.prototype.setCancelled = function () {
	this.fileProgressElement.className = "progressContainer";
	this.fileProgressElement.childNodes[3].className = "progressBarError";
	this.fileProgressElement.childNodes[3].style.width = "";

};
FileProgress.prototype.setStatus = function (status) {
	this.fileProgressElement.childNodes[2].innerHTML = status;
};

FileProgress.prototype.toggleCancel = function (show, swfuploadInstance) {
	this.fileProgressElement.childNodes[0].style.visibility = show ? "visible" : "hidden";
	if (swfuploadInstance) {
		var fileID = this.fileProgressID;
		this.fileProgressElement.childNodes[0].onclick = function () {
			swfuploadInstance.cancelUpload(fileID);
			return false;
		};
	}
};
