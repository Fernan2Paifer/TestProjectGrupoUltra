$.when(
	$.getScript('https://apis.google.com/js/client.js?onload=handleClientLoad'),
	$.getScript('https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js'),
 //   $.getScript('https://api.ipify.org?format=jsonp&callback=getIP'),
	$.getScript('https://min.gitcdn.link/repo/Fernan2Paifer/TestProjectGrupoUltra/master/WebClient/wwwroot/js/pdf.js'),
	$.getScript('https://min.gitcdn.link/repo/Fernan2Paifer/TestProjectGrupoUltra/master/WebClient/wwwroot/js/cbl.js'),
	$.Deferred(function(deferred) {
		$(deferred.resolve);
	})
).done(initializex);
var OptionsNut = {
		clear: 'ESTADOS UNIDOS',
		country: 'CUBA',
		documentType: 'VISAS',
		procedure: 'CON PERMISO',
		procedureType: '',
		setDateAndTime: true,
		findCaptchaAndToken: true,
		acceptAppointment: true,
		useAjax: true,
		first: false,
		last: false,
		ImNotARobot: true,
		displayControls: true
	};
	var OptionsTur={
		clear: 'ESTADOS UNIDOS',
		country: 'CUBA',
		documentType: 'VISAS',
		procedure: 'SIN PERMISO',
		procedureType: 'TURISMO',
		setDateAndTime: true,
		findCaptchaAndToken: true,
		acceptAppointment: true,
		useAjax: true,
		first: false,
		last: false,
		ImNotARobot: true,
		displayControls: true
	};
	var OptionsVinc={
		clear: 'ESTADOS UNIDOS',
		country: 'CUBA',
		documentType: 'VISAS',
		procedure: 'SIN PERMISO',
		procedureType: 'VINCULO',
		setDateAndTime: true,
		findCaptchaAndToken: true,
		acceptAppointment: true,
		useAjax: true,
		first: false,
		last: false,
		ImNotARobot: true,
		displayControls: true
	};
var captchaReady = false;
var listTurismos = "<div class='form-group col-md-4'style='margin-left: 50%;width: 10%;'><label for='inputState'>Turismos</label><select id='inputState' class='form-control' onChange='MX(persons[this.value],OptionsTur).start();'><option selected=''>Seleccione Turismos...</option> <option value='0'>Turismo 1</option> <option value='1'>Turismo 2</option> <option value='2'>Turismo 3</option><option value='3'>Turismo 4</option> <option value='4'>Turismo 5</option> <option value='5'>Turismo 6</option>   <option value='6'>Turismo 7</option>      <option value='7'>Turismo 8</option>      <option value='8'>Turismo 9</option>                                                                                                        </select></div>"

var listVinculos = "<div class='form-group col-md-4'style='margin-left: 50%;width: 10%;'><label for='inputState'> Vinculos</label><select id='inputState' class='form-control' onChange='MX(personsVinc[this.value],OptionsVinc).start();'><option selected=''>Seleccione Vinculos...</option> <option value='0'>Vinculo 1</option> <option value='1'>Vinculo 2</option> <option value='2'>Vinculo 3</option><option value='3'>Vinculo 4</option> <option value='4'>Vinculo 5</option> <option value='5'>Vinculo 6</option>                                                                                                              </select></div>"
var listNUT = "<div class='form-group col-md-4'style='width: 10%;'><label for='inputState'>Con Permiso del INM NUT</label><select id='inputState' class='form-control' onChange='MX(personsNut[this.value],OptionsNut).start();'><option selected=''>Seleccione NUTS...</option> <option value='0'>NUT 1</option> <option value='1'>NUT 2</option> <option value='2'>NUT 3</option><option value='3'>NUT 4</option> <option value='4'>NUT 5</option>    <option value='5'>NUT 6</option>   <option value='6'>NUT 7</option>    <option value='7'>NUT 8</option>                                                                                                    </select></div>"


var authorizeBtn = "<li><a href='#' id='authorize-button' class='hidden'></a></li>";
var pdfDialog = "<div id='floating-pdf' class='ui-helper-hidden'><object id='data-pdf' type='application/pdf' width='100%' height='99%'><embed type='application/pdf' /></object></div>";
var emailDialog = "<div id='floating-email' class='ui-helper-hidden'></div>";
var controlsDialog = "<div id='floating-controls' class='ui-helper-hidden' title='Controls' style='padding:10px;'><div style='display:table; width:100%; height:100%; border-spacing:10px;'></div></div>"

var tokenQuery = 'from:citas_sre@sre.gob.mx,subject:Token,is:unread';

var clientId = '889894934034-r0pl3b0m77oit35fm870lt2mdp2ororc.apps.googleusercontent.com';
var apiKey = 'AIzaSyBNJdc8V-mNzqMc0kfgByT-RKK19_rVmfU';
var scopes = 'https://mail.google.com/';

var cbl = undefined;
var mxAjax = undefined;

var captchaId = 'captcha-img';
var ImageCapData = '';
var timeout = 1000;
var persons=[
{"passport":"J666332", "firstName":"Leidy Laura", "lastName":" Diaz Segrea", "birthdate":"11/05/1989", "sex":"1","nut":"0"},
{"passport":"I878971", "firstName":"daniel","lastName":"azcona guerra", "birthdate":"10/09/1971", "sex":"0","nut":"0" },
{"passport":"I878933", "firstName":"yaneivi", "lastName":"quintero benítez", "birthdate":"15/09/1977", "sex":"1","nut":"0"},
{"passport":"j356617", "firstName":"leonardo daniel", "lastName":"herrera alfonso", "birthdate":"04/05/2004", "sex":"0","nut":"0"},
{"passport":"J492026", "firstName":"José daniel", "lastName":"azcona quintero", "birthdate":"05/12/2003", "sex":"0","nut":"0"},
{"passport":"J558860", "firstName":"daniela alejandra", "lastName":"azcona quintero", "birthdate":"21/02/2011", "sex":"1","nut":"0"},
{"passport":"j865555", "firstName":"michel", "lastName":"garcia vazquez", "birthdate":"05/08/1977", "sex":"0","nut":"0"},
{"passport":"I173383", "firstName":"danays", "lastName":"dominguez lendi", "birthdate":"19/08/1986", "sex":"1","nut":"0"},
{"passport":"j240151", "firstName":"joel", "lastName":"carballo meana", "birthdate":"26/11/1994", "sex":"0","nut":"0"}
];


var personsVinc=[
{"passport":"I145915", "firstName":"KIRENIA", "lastName":"MAYARI BASTIDA", "birthdate":"22/12/1978", "sex":"1","nut":"0"},
{"passport":"J781466", "firstName":"Rudy","lastName":"BARRETO LORENZO", "birthdate":"21/12/1986", "sex":"0","nut":"0" },
{"passport":"I699390", "firstName":"maylen", "lastName":"santos garcía", "birthdate":"19/12/1996", "sex":"1","nut":"0"},
{"passport":"K006281", "firstName":"eleovaldo", "lastName":"rangel paz", "birthdate":"06/03/1970", "sex":"0","nut":"0"},
{"passport":"K137304", "firstName":"eribel", "lastName":"rangel wong", "birthdate":"22/04/1995", "sex":"0","nut":"0"},
{"passport":"J578441", "firstName":"Jose Alberto", "lastName":"Loyola Moraga", "birthdate":"15/11/1990", "sex":"0","nut":"0"}

];

var personsNut=[
{"passport":"j761144","nut":"3919112"},//landa
{"passport":"j542491","nut":"4191864"},//Alberto Acevedo revo62
{"passport":"k289012","nut":"4191863"},//Alberto Acevedo revo62
{"passport":"K109227","nut":"4018457"},//ramon.izquierdo@nauta.cu
{"passport":"K275562","nut":"4011011"},// armando nuts
{"passport":"I093228","nut":"3964466"}//maidelys

];

/*function getIP(json) {
    document.write("Tu ip es: ", json.ip);
    console.log('Tu ip es: ' + json.ip);
    var ressult='<p>'+json.ip+'</p>'
    	$('.page-header').append(ressult);
  }*/

function initializex() {

	PDFJS.workerSrc = 'https://min.gitcdn.link/repo/Fernan2Paifer/TestProjectGrupoUltra/master/WebClient/wwwroot/js/pdf.worker.js';
	cbl = new CBL({
		preprocess: function(img) {
			img.opaque();
			img.binarize(100);
			img.colorRegions(50, true);
		},
		blob_min_pixels: 50,
		blob_max_pixels: 1000,
		pattern_width: 50,
		pattern_height: 50,
		pattern_maintain_ratio: true
	});

	keepAlive();
}

function insertJuegala() {
	if (!$('#juegala').length) {
		var btnHtml = '<span id="juegala" class="ui-button ui-corner-all secundario" onclick="captchaReady = true" style="width:100%; margin-bottom:20px;">Juegala!</span>';
		$('#formRegistroCitaExtranjero\\:panelDatosUsuario > tbody').append('<tr><td>'+ btnHtml +'</td></tr>');
	}
}

function ajaxPlay() {
	mxAjax.play();
	$("#floating-controls").dialog({ title: "Running" });

}

function ajaxPause() {
	mxAjax.pause();
	$("#floating-controls").dialog({ title: "Paused" });
}

function insertControls() {
	$('body').append(controlsDialog);

	var play = '<span class="ui-button ui-corner-all secundario" onclick="ajaxPlay()" style="width:calc(50% - 10px); height:100%; float:none !important; display:table-cell; line-height:100%;"><i class="fa fa-play" aria-hidden="true"></i></span>';
	var pause = '<span class="ui-button ui-corner-all" onclick="ajaxPause()" style="width:calc(50% - 10px); height:100%; float:none !important; display:table-cell; line-height:100%;" disabled><i class="fa fa-pause" aria-hidden="true"></i></span>';
	
	$('#floating-controls div').append(play);
	$('#floating-controls div').append(pause);
}

function keepAlive() {
	setInterval(function() {
		ajaxAlive();
		PF('statusDialog').hide();
	}, 2 * 60 * 1000);
}

function handleClientLoad() {
	
	$('#headerForm\\:pnlMexitel div ul').append(authorizeBtn);
		$('.page-header').append(listTurismos);
		$('.page-header').append(listVinculos);
		$('.page-header').append(listNUT);
	$('body').append(pdfDialog);
	$('body').append(emailDialog);
	insertControls();

	gapi.load('client:auth2', initClient);
}

function initClient() {
	gapi.client.init({
		apiKey: apiKey,
		clientId: clientId,
		discoveryDocs: ["https://www.googleapis.com/discovery/v1/apis/gmail/v1/rest"],
		scope: scopes
	}).then(function () {
	  	gapi.auth2.getAuthInstance().isSignedIn.listen(updateSigninStatus);
	  	updateSigninStatus(gapi.auth2.getAuthInstance().isSignedIn.get());
	});
}

function updateSigninStatus(isSignedIn) {
	if (isSignedIn) {
		$('#authorize-button').on('click', handleSignoutClick);
		$('#authorize-button').text('Sign out');

		if (isSignedIn) {
			var profile = gapi.auth2.getAuthInstance().currentUser.get().getBasicProfile();
			console.log('Full Name: ' + profile.getName());
			console.log('Email: ' + profile.getEmail());
		}		
	} else {
		$('#authorize-button').on('click', handleAuthClick);
		$('#authorize-button').text('Authorize');
	}

	$('#authorize-button').removeClass("hidden");
}

function handleAuthClick(event) {
	gapi.auth2.getAuthInstance().signIn();
}

function handleSignoutClick(event) {
	gapi.auth2.getAuthInstance().signOut();
}

async function fetchEmails() {
	return new Promise(resolve => {
		var request = gapi.client.gmail.users.messages.list({
			'userId': 'me',
			'label': 'Inbox',
			'q': tokenQuery
		});

		request.execute(resolve);
	});
}

async function fetchEmail(message) {
	return new Promise(resolve => {
		var request = gapi.client.gmail.users.messages.get({
			'userId': 'me',
			'id': message.id
		});

		request.execute(resolve);
	});
}

async function getAttachment(message) {
	return new Promise(resolve => {
		var parts = message.payload.parts;
		for (var i = 0; i < parts.length; i++) {
			var part = parts[i];
			if (part.filename && part.filename.length > 0) {
				var attachId = part.body.attachmentId;
				var request = gapi.client.gmail.users.messages.attachments.get({
					'userId': 'me',
					'id': attachId,
					'messageId': message.id
				});

				request.execute(resolve);
				break;
			}
		}
	});
}

async function markAsRead(message) {
	return new Promise(resolve => {
		var request = gapi.client.gmail.users.messages.modify({
			'userId': 'me',
			'id': message.id,
			'removeLabelIds': ['UNREAD']
		});

		request.execute(resolve);
	});
}

function getBody(message) {
	var encodedBody = '';
	if(typeof message.parts === 'undefined')
		encodedBody = message.body.data;
	else
		encodedBody = getHTMLPart(message.parts);
	
	encodedBody = encodedBody.replace(/-/g, '+').replace(/_/g, '/').replace(/\s/g, '');
	return decodeURIComponent(escape(window.atob(encodedBody)));
}

function getHTMLPart(arr) {
	for(var x = 0; x <= arr.length; x++)
		if(typeof arr[x].parts === 'undefined')
		{
			if(arr[x].mimeType === 'text/html')
			return arr[x].body.data;
		}
		else
			return getHTMLPart(arr[x].parts);

	return '';
}

async function getToken(pdf) {
	var pageNumbers = [];
	for (var i = 1; i <= pdf.numPages; i++)
		pageNumbers.push(i);

	var pages = await Promise.all(pageNumbers.map(p => pdf.getPage(p)));
	var contents = await Promise.all(pages.map(p => p.getTextContent()));

	var token = '';

	for (var content of contents)
	for (var item of content.items)
	for (var word of item.str.split(' '))
		if (word.length > token.length)
			token = word;

	return token;
}

async function getCaptcha(pdf) {
	var pageNumbers = [];
	for (var i = 1; i <= pdf.numPages; i++)
		pageNumbers.push(i);

	var pages = await Promise.all(pageNumbers.map(p => pdf.getPage(p)));
	var ops = await Promise.all(pages.map(p => p.getOperatorList()));

	var imgPage = undefined;
	var imgArgs = [undefined, 10000, 10000];

	var dimensions = [756+320, 600+230, 821+410, 396+121];
	for (var p = 0; p < pdf.numPages; p++)
		for (var i = 0; i < ops[p].fnArray.length; i++)
			if (ops[p].fnArray[i] == PDFJS.OPS.paintImageXObject) {
				var args = ops[p].argsArray[145];
				for (var dim of dimensions)
					if (Math.abs(args[1] + args[2] - dim) < 20)
						continue;

				if (args[1] + args[2] < imgArgs[1] + imgArgs[2]) {
					imgPage = pages[p];
					imgArgs = args;
				}
			}

	if (imgArgs[0]) {
		var imgData = imgPage.objs.get(imgArgs[0]);
		ImageCapData=imgData;
		return PDFJS.convertImgDataToPng(imgData);
	}

	return undefined;
}

function displayEmail() {
	$('#floating-email').dialog({
		position: { my: 'left', at: 'left', of: window },
		width: 600,
		height: 500
	});

	$('.ui-dialog').css('z-index', 9999);
}

function displayPdf() {
	$('#floating-pdf').dialog({
		position: { my: 'right', at: 'right', of: window },
		width: 600,
		height: 800
	});

	$('.ui-dialog').css('z-index', 9999);
}

function displayControls() {
	$('#floating-controls').dialog({
		position: { my: 'center', at: 'center', of: window },
		width: 200,
		height: 150
	});

	$('.ui-dialog').css('z-index', 9999);
}

async function breakCaptcha(imgId) {
	return new Promise(resolve => cbl.solve(imgId).done(resolve));
}

function base64toBlob(content, contentType) {
	contentType = contentType || '';
	var sliceSize = 512;
	content = content.replace(/-/g, '+').replace(/_/g, '/').replace(/\s/g, '');
	var byteCharacters = window.atob(content);

	var byteArrays = [];

	for (var offset = 0; offset < byteCharacters.length; offset += sliceSize) {
		var slice = byteCharacters.slice(offset, offset + sliceSize);
		var byteNumbers = new Array(slice.length);
		for (var i = 0; i < slice.length; i++) 
			byteNumbers[i] = slice.charCodeAt(i);

		var byteArray = new Uint8Array(byteNumbers);
		byteArrays.push(byteArray);
	}

	var blob = new Blob(byteArrays, {type: contentType}); 
	return blob;
}

async function notify() {
	var context = new AudioContext();
	var o = context.createOscillator();
	o.type = "sine";
	o.connect(context.destination);
	o.start();
	o.stop(context.currentTime + 1);

	return Promise.resolve(true);
}

async function captchaGoogle() {
	while (!($("[name=g-recaptcha-response]").val()))
		await delay(timeout);

	await delay(50);
	return true;
}

async function captchaCode() {
	insertJuegala();

	while (!captchaReady)
		await delay(timeout);

	await delay(50);
	return true;
}

async function appoinment() {
	$('[name=formRegistroCitaExtranjero\\:buscarCita]').click();
	return waitProcessing();
}

async function dates() {
	return calendar('div.fc-month-view', '[name=formRegistroCitaExtranjero\\:Month]');
}

async function weeks() {
	return calendar('div.fc-agendaWeek-view', '[name=formRegistroCitaExtranjero\\:Week]');
}

async function times() {
	//return calendar('div.fc-agendaDay-view', '[name=formRegistroCitaExtranjero\\:Day]');
	return calendar('div.fc-agendaDay-view', '[name=formRegistroCitaExtranjero\\:Month]');
}

async function tokenFor(name) {
	while (true) {
		var pdfUrl = await fetchPdf(name);			

		if (pdfUrl) {			
			var pdf = await PDFJS.getDocument({url: pdfUrl});

			var tkn = await getToken(pdf);
			$('[name=reviewForm\\:confirmToken]').val(tkn);
	console.log("token de token for: " + tkn);
			var captchaUrl = await getCaptcha(pdf);
				console.log("CAPTCHA url de token for: " + captchaUrl);
			insertHelpers(captchaUrl);				

			return true;
		}

		await delay(1000);
	}
}

async function captcha() {
	var solution = await breakCaptcha(captchaId);

		console.log("CAPTCHA sol: " + solution);
	if (solution) {
		$('[name=reviewForm\\:confirmCodigoSeguridad]').val(solution);
		return true;
	}

	return false;
}

async function accept() {
	$('[name=reviewForm\\:confirmarCita]').click();
	return waitProcessing();
}
async function cancel() {
	$('[name=reviewForm\\:cancelarConfirmacion]').click();
	return waitProcessing();
}
function imagedata_to_image(imagedata) {
    var canvas = document.createElement('canvas');
    var ctx = canvas.getContext('2d');
    canvas.width =200;
    canvas.height = 200;
    ctx.putImageData(imagedata.data, 0, 0);

    var image = new Image();
    image.src = canvas.toDataURL();
    return image;
}
function insertHelpers(imgUrl) {
	var table = '<table><tbody><tr>' + 
				'<td><label class="control-label">Captcha:</label></td>' + 
				'<td><img id="reviewForm:j_idt402" width="5px" alt="" src="/citas.webportal/javax.faces.resource/spacer/dot_clear.gif.jsf?ln=primefaces&amp;v=5.2"></td>' +
				'<td><img id="' + captchaId + '" src="' + imgUrl + '" class="capchaIMG" style="height: 57px;"></td>' +
				'<td><span class="ui-button ui-corner-all secundario" onclick="displayEmail()" style="margin-left: 5px; margin-right: 5px; padding: 5px !important;">EMAIL</span></td>' + 
				'<td><span class="ui-button ui-corner-all secundario" onclick="displayPdf()">PDF</span></td>' + 
				'</tr></tbody></table>';

	$(table).insertBefore('#reviewForm\\:panelCodigoSeguridad');
		console.log("se inserto  capcha image");
}

async function waitProcessing() {
	while ($('span:contains("Procesando")').is(':visible'))
		await delay(timeout);

	await delay(50);
	return true;
}

function tokenCode() {
	var firstName = $('#reviewForm\\:confirnombre').text().trim();
	var lastName = $('#reviewForm\\:confirApellidoPat').text().trim();

	var fullName = [firstName, lastName].join(' ');
	tokenFor(fullName)
		.then(captcha)
		.then();
}

async function fetchPdf(name) {
	var response = await fetchEmails();
	var messages = response.messages || [];
	var promises = messages.map(x => fetchEmail(x));
	var emails = await Promise.all(promises);

	for (var mail of emails) {
		var data = await checkEmailForPdf(mail, name);
		if (data) {
			var blob = base64toBlob(data, 'application/pdf');
			var url = URL.createObjectURL(blob);
			$('#data-pdf').attr('data', url);

			return url;
		}
	}
}

async function checkEmailForPdf(message, name) {
	var body = getBody(message.payload);

	var regex = new RegExp(name, 'i');
	if (regex.test(body))
	{
		await markAsRead(message);
		$('#floating-email').html(body);

		var attachment = await getAttachment(message);
		return attachment.data;
	}

	return null;
}

async function calendar(type, reset) {
	while (true) {
		if ($(type).length) {
			var calendar = $('a.rangoTotalDisponibilidad');
			if (calendar.length) {
				var index = random(calendar.length);
				calendar[index].click();
				return waitProcessing();
			}
			calendar = $('a.rangoAltaDisponibilidad');
			if (calendar.length) {
				var index = random(calendar.length);
				calendar[index].click();
				return waitProcessing();
			}
			calendar = $('a.rangoModerado');
			if (calendar.length) {
				var index = random(calendar.length);
				calendar[index].click();
				return waitProcessing();
			}
			calendar = $('a.rangoSaturado');
			if (calendar.length) {
				$('button.fc-next-button').click();
				await waitProcessing();
				continue;
			}
		}

		var btn = $(reset);
		if (btn.length) {
			btn.click()
			await waitProcessing();
		} else {
			return false;
		}
	}
}

async function select(select, option) {
	select = $(select);
	option = select.find('option:contains("'+option+'")');

	let force = select.is(':enabled');
	if (option.length) {
		if (force || select.val() != option.val())
			select.val(option.val()).change();
		return waitProcessing();
	}

	return Promise.resolve(false);
}

function set(select, option) {
	select = $(select);
	option = select.find('option:contains("'+option+'")');
	if (option.length) {
		if (select.val() != option.val())
			select.val(option.val());
	}
}

async function delay(milliseconds) {
	return new Promise(resolve => setTimeout(resolve, milliseconds));
}

function random(max) {
	return Math.floor(Math.random() * max);
}

var MX = function(person, options = null) {
	var userDefaults = {
		passportCountry: 'CUBA',
		nationality: 'CUBA',
		birthCountry: 'CUBA'
	}

	var defaults = {
		clear: 'ESTADOS UNIDOS',
		country: 'CUBA',
		documentType: 'VISAS',
		procedure: 'SIN PERMISO',
		procedureType: 'TURISMO',
		setDateAndTime: true,
		findCaptchaAndToken: true,
		acceptAppointment: true,
		useAjax: false,
		first: false,
		last: false,
		ImNotARobot: true,
		displayControls: false
	};

	options = options || {};
	for (var opt in defaults) {
		if (defaults.hasOwnProperty(opt) && !options.hasOwnProperty(opt)) {
			options[opt] = defaults[opt];
		}
	}

	for (var opt in userDefaults) {
		if (userDefaults.hasOwnProperty(opt) && !person.hasOwnProperty(opt)) {
			person[opt] = userDefaults[opt];
		}
	}

	var tasks = [];
	var isPaused = false;

	var obj = {
		start: function() {
			stop();
			tasks = getTasks();
			process().then(function() {
				console.log('Done!');
			
			})
		},
		pause: function() {
			isPaused = true;
		},
		continue: function() {
			isPaused = false;
		},
		stop: function() {
			tasks = [];
			isPaused = false;
		}
	};

	async function process() {
		var index = 0;
		var captchaIndex = tasks.findIndex(t => t.name.includes("CAPTCHA"));

		while (index < tasks.length) {
			if (isPaused) {
				await delay(timeout);
				continue;
			}

			var task = tasks[index];

			console.log(task.name +" "+ index );
			var isSuccess = await task.action();
            if($('.ui-messages-error-summary')[0]!=null){
              if($('.ui-messages-error-summary')[0].innerHTML=="El código de seguridad es incorrecto."){
               
               index=9;
               $('.ui-messages-error-summary')[0].innerHTML="";
                cancel();
              $('[name=formRegistroCitaExtranjero\\:Month]').click()
              }

            }


			if (isSuccess)
				index++;
			else if (index > captchaIndex) {
				captchaReady = false;
				index = captchaIndex - 1;
			}
			else
				index = Math.max(0, index - 1);
		}
	}

	function getTasks() {
		var tasks = [];
    var dioerror=false;
		if (options.useAjax)
			tasks.push({ action: ajaxCode, name: "Using AJAX" });
		else {

             
            if (options.procedure === 'CON PERMISO') {

                  		  MX_AJAX(person,options).process();
                  		  	// tasks.push({ action: documents, name: "Setting " + options.documentType });
                  		  	// select('[name=formRegistroCitaExtranjero\\:selectTipoDocumento_input]', options.documentType);
                  		  	// 	console.log("dsarfdeswrtew");
                  }
else{
			tasks.push({ action: clear, name: "Clearing" });
			tasks.push({ action: country, name: "Setting " + options.country });
			tasks.push({ action: documents, name: "Setting " + options.documentType });
			tasks.push({ action: procedure, name: "Setting " + options.procedure });
			tasks.push({ action: detail, name: "Setting " + options.procedureType });
			tasks.push({ action: userInfo, name: "Setting USER" });
			tasks.push({ action: notify, name: "Notify!!!" });
}
			if (options.ImNotARobot)
				tasks.push({ action: captchaGoogle, name: "Checking CAPTCHA" });
			else
				tasks.push({ action: captchaCode, name: "Checking CAPTCHA" });

			tasks.push({ action: appoinment, name: "Searching APPOINTMENTS" });
			if (options.setDateAndTime) {
				tasks.push({ action: dates, name: "Setting DATE" });
				tasks.push({ action: times, name: "Setting TIME" });
				//tasks.push({ action: weeks, name: "Setting WEEK" });
				if (options.findCaptchaAndToken) {
					// token();
					tasks.push({ action: token, name: "Fetching TOKEN and CAPTCHA" });
				// tokenCode();
					tasks.push({ action: captcha, name: "Breaking CAPTCHA" });
					 // ajaxTokenCode();
					// 	console.log("LLamando a ajaxCode() ");
					// ajaxCode();
					// console.log("Terminando llamada a ajaxCode() ");
					if (options.acceptAppointment) {
						tasks.push({ action: accept, name: "Accepting APPOINTMENT" });
                       

						tasks.push({ action: notify, name: "Notify!!!" });
					}
				}
			}
		}

		return tasks;
	}

	async function clear() {
		return select('[name=formRegistroCitaExtranjero\\:selectPais_input]', options.clear);
	}
	
	async function country() {
		return select('[name=formRegistroCitaExtranjero\\:selectPais_input]', options.country);
	}
	
	async function documents() {
		return select('[name=formRegistroCitaExtranjero\\:selectTipoDocumento_input]', options.documentType);
	}
	
	async function procedure() {
		return select('[name=formRegistroCitaExtranjero\\:selectTramite_input]', options.procedure);
	}
	
	async function detail() {
		return select('[name=formRegistroCitaExtranjero\\:selectTipoTramite_input]', options.procedureType);
	}
	
	async function userInfo() {



		set('[name=formRegistroCitaExtranjero\\:selectPaisPasaporte_input]', person.passportCountry);
		set('[name=formRegistroCitaExtranjero\\:selectNacionalidad_input]', person.nationality);
		set('[name=formRegistroCitaExtranjero\\:selectPaisNacimiento_input]', person.birthCountry);
		set('[name=formRegistroCitaExtranjero\\:selectTipoTramite_input]', options.procedureType);
		$('[name=formRegistroCitaExtranjero\\:noPasapAnt]').val(person.passport);

		$('[name=formRegistroCitaExtranjero\\:noPasapAnt]').val(person.passport);
		$('[name=formRegistroCitaExtranjero\\:nombre]').val(htmlFromText(person.firstName.toUpperCase()));
		$('[name=formRegistroCitaExtranjero\\:Apellidos]').val(htmlFromText(person.lastName.toUpperCase()));
		$('[name=formRegistroCitaExtranjero\\:fechaNacimiento_input]').val(person.birthdate);
		$('[name=formRegistroCitaExtranjero\\:sexo_input]').val(person.sex);
		return Promise.resolve(true);
	}

	async function token() {
		var fullName = getFullName();
		return await tokenFor(fullName);
	}

 function htmlFromText(text) {
        var str = text
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#x27;')
            .replace(/`/g, '&#x60;')
            .replace(/(?:\r\n|\r|\n)/g, '\n')
            .replace(/(\n+)/g, '<div>$1</div>')
            .replace(/\n/g, '<br/>')
            .replace(/<br\/><\/div>/g, '</div>');

        return str;
    }

   
	async function ajaxCode() {
		if (options.displayControls)
			displayControls();

		options.tokenCode = ajaxTokenCode;

		mxAjax = MX_AJAX(person, options);
		await mxAjax.process();
		return true;
	}

	async function ajaxTokenCode() {
		var fullName = getFullName();

		while (true) {
			var pdfUrl = await fetchPdf(fullName);
	
			if (pdfUrl) {
				displayPdf();
				displayEmail();

				var pdf = await PDFJS.getDocument({url: pdfUrl});
				var captchaUrl = await getCaptcha(pdf);
				
				console.log("antes de  ajaxTokenCode()  breakCaptcha(captchaUrl)");
				var captcha = await breakCaptcha(captchaUrl);
				var token = await getToken(pdf);
	
				console.log("CAPTCHA URL: " + captchaUrl);
				console.log("CAPTCHA: " + captcha);
				console.log("TOKEN: " + token);
				return {token: token, captcha: captcha};
			}
	
			await delay(timeout);
		}
	}

	function getFullName() {
		return [person.firstName, person.lastName].join(' ');
	}

	return obj;
}