const axios = require('axios');
const path = require('path');
const crypto = require("crypto");
const fs = require('fs');
const { setTimeout } = require('timers');

module.exports = (app) => {
    //lightswitch
    app.get('/lightswitch/api/service/bulk/status', (req, res) => {
        res.json([{
            "serviceInstanceId": "fortnite",
            "status": "UP",
            "message": "GO AWAY KID",
            "maintenanceUri": null,
            "allowedActions": ["PLAY", "DOWNLOAD"],
            "banned": false
        }]);
    });

    //external auth
    app.get('/account/api/public/account/:accountId/externalAuths', (req, res) => {
        res.json([])
	});

    //version check
    app.get('/fortnite/api/v2/versioncheck/:version', (req, res) => {
        res.json({"type": "NO_UPDATE"})
	});

    //privacy
    app.get('/fortnite/api/game/v2/privacy/account/:accountId', (req, res) => {
        res.json({
            "accountId": req.params.accountId,
            "optOutOfPublicLeaderboards": false
        })
    });

    //waiting room
    app.get('/waitingroom/api/waitingroom', (req, res) => {
        res.status(204).end();
    });

    //grant access
    app.post('/fortnite/api/game/v2/grant_access/:accountId', (req, res) => {
        res.status(204).end();
    });

    //enabled features
    app.get('/fortnite/api/game/v2/enabled_features', (req, res) => {
        res.json([])
    });

    //receipt
	app.get('/fortnite/api/receipts/v1/account/:accountId/receipts', (req, res) => {
		res.json([])
    });
    
	//blocklist
	app.get('/friends/api/public/blocklist/:accountId', (req, res) => {
		res.json({
			blockedUsers: []
		})
    });
    
	//friends setting
	app.get('/friends/api/v1/:accountId/settings', (req, res) =>  {
		res.json({
			acceptInvites: "public"
		})
    });
    
	//recent players
	app.get('/friends/api/public/list/fortnite/:accountId/recentPlayers', (req, res) => {
		res.json([]);
    });
    
	//friends list
	app.get('/friends/api/public/friends/:accountId', (req, res) => {
		res.json([]);
    });
    
    //datarouter
	app.post('/datarouter/api/v1/public/*', (req, res) => {
		res.status(204).end();
    });

    //presence ?
	app.get('/presence/api/v1/_/:accountId/settings/subscriptions', (req, res) => { res.status(204).end(); });
	app.get('/party/api/v1/Fortnite/user/:accountId/notifications/undelivered/count', (req, res) => { res.status(204).end(); });
    
	app.get('/socialban/api/public/v1/:accountId', (req, res) => {
		res.status(204).end();
	});

    app.get('/content-controls/:accountId', function (req, res) {
		res.status(204).end();
	});
    
	//platform
	app.post('/fortnite/api/game/v2/tryPlayOnPlatform/account/:accountId', (req, res) => {
		res.set('Content-Type', 'text/plain');
		res.send(true);
	});
  
    //sac
    app.get('/affiliate/api/public/affiliates/slug/:affiliateName', (req, res) => {
		res.json({
			id: "aabbccddeeff11223344556677889900",
			slug: req.params.affiliateName,
			displayName: req.params.affiliateName,
		    status: "ACTIVE",
			verified: true
		})
	});
    
	//cloudstorage
	app.get('/fortnite/api/cloudstorage/system', async (req, res) => {
		let engine = fs.readFileSync(path.join(__dirname ,'../CloudStorge/DefaultEngine.ini'));
		let runtime = fs.readFileSync(path.join(__dirname ,'../CloudStorge/DefaultRuntimeOptions.ini'));
		let game = fs.readFileSync(path.join(__dirname ,'../CloudStorge/DefaultGame.ini'));
		res.json([{
			"uniqueFilename": "3460cbe1c57d4a838ace32951a4d7171",
			"filename": "DefaultEngine.ini",
			"hash": crypto.createHash("sha1").update(engine).digest("hex"),
			"hash256": crypto.createHash("sha256").update(engine).digest("hex"),
			"length": engine.length,
			"contentType": "application/octet-stream",
			"uploaded": fs.statSync(path.join(__dirname ,'../CloudStorge/DefaultEngine.ini')).mtime,
			"storageType": "S3",
			"doNotCache": false
		},
		{
			"uniqueFilename": "c52c1f9246eb48ce9dade87be5a66f29",
			"filename": "DefaultRuntimeOptions.ini",
			"hash": crypto.createHash("sha1").update(runtime).digest("hex"),
			"hash256": crypto.createHash("sha256").update(runtime).digest("hex"),
			"length": runtime.length,
			"contentType": "application/octet-stream",
			"uploaded": fs.statSync(path.join(__dirname ,'../CloudStorge/DefaultRuntimeOptions.ini')).mtime,
			"storageType": "S3",
			"doNotCache": false
		},
		{
			"uniqueFilename": "a22d837b6a2b46349421259c0a5411bf",
			"filename": "DefaultGame.ini",
			"hash": crypto.createHash("sha1").update(game).digest("hex"),
			"hash256": crypto.createHash("sha256").update(game).digest("hex"),
			"length": game.length,
			"contentType": "application/octet-stream",
			"uploaded": fs.statSync(path.join(__dirname ,'../CloudStorge/DefaultGame.ini')).mtime,
			"storageType": "S3",
			"doNotCache": false
		}])
	});

	//cba adding more
	app.get('/fortnite/api/cloudstorage/system/3460cbe1c57d4a838ace32951a4d7171', (req, res) => {
		res.setHeader("content-type", "application/octet-stream")
		res.sendFile(path.join(__dirname ,'../CloudStorge/DefaultEngine.ini'));
	});

	app.get('/fortnite/api/cloudstorage/system/c52c1f9246eb48ce9dade87be5a66f29', (req, res) => {
		res.setHeader("content-type", "application/octet-stream")
		res.sendFile(path.join(__dirname ,'../CloudStorge/DefaultRuntimeOptions.ini'));
	});
	
	app.get('/fortnite/api/cloudstorage/system/a22d837b6a2b46349421259c0a5411bf', (req, res) => {
		res.setHeader("content-type", "application/octet-stream")
		res.sendFile(path.join(__dirname ,'../CloudStorge/DefaultGame.ini'));
	});
	
	app.get('/fortnite/api/cloudstorage/user/:accountId', (req, res) => {
		res.json([])
	});
	app.get('/fortnite/api/cloudstorage/user/:accountId/:fileName', (req, res) => {
		res.status(204).send();
	});
	app.put('/fortnite/api/cloudstorage/user/:accountId/:fileName', (req, res) => {
		res.status(204).send();
    });
    //keychain
    app.get('/fortnite/api/storefront/v2/keychain', (req, res) => { 
		axios.get("https://api.nitestats.com/v1/epic/keychain").then(response => {
			res.json(response.data);
		})
	})
	
    //party
    app.get('/party/api/v1/Fortnite/user/:accountId', (req, res) => {
		res.json({
			current: [],
			pending: [],
			invites: [],
			pings: []
		});
	});

	/* Disable matchmaking
	app.get("/fortnite/api/matchmaking/session/findPlayer/:id", (req, res) => {
		res.json([])
	})

	app.all("/fortnite/api/game/v2/matchmakingservice/ticket/player/:accountId", (req, res) => {
		var subregions = req.params.subregions
		var partyId = req.params.partyId
		var platform = req.params.platform

		attribs = {    
			"player.subregions": subregions,
			"player.hasMultipleInputTypes": "",
			"player.option.partyId": partyId,
			"player.option.uiLanguage": "",
			"player.platform": platform,
			"player.preferredSubregion": "",
			"player.option.spectator": "",
			"player.inputTypes": "",
			"player.input": "",
			"playlist.revision": "",
			"player.teamFormat": "",
			"player.option.microphoneEnabled": ""}
		
			var ticketToken = jwt.sign({
			playerId: req.params.accountId,
			partyPlayerIds: [req.params.accountId],
			bucketId: "",
			attributes: attribs,
			expireAt: ""
		}, "bignuts")

		res.json({
			serviceUrl: "",
			ticketType: "",
			payload: ticketToken,
			signature: "bignuts"
		});
	});

	app.all("/fortnite/api/game/v2/matchmaking/account/:accId/session/:sessId", (req, res) => {
		res.json({
			accountId: req.params.accId,
			sessionId: "",
			key:""
		});
	});	
	
	app.all("/fortnite/api/matchmaking/session/:sessionId", (req, res) => {
		res.json({
			"id": "",
			"ownerId": "",
			"ownerName": "",
			"serverName": "",
			"serverAddress": "0.0.0.0",
			"serverPort": 0,
			"maxPublicPlayers": 0,
			"openPublicPlayers": 0,
			"maxPrivatePlayers": 0,
			"openPrivatePlayers": 0,
			"attributes": {
				"REGION_s": "",
				"GAMEMODE_s": "",
				"ALLOWBROADCASTING_b": "",
				"SUBREGION_s": "",
				"DCID_s": "",
				"NEEDS_i": 0,
				"NEEDSSORT_i": 0,
				"tenant_s": "",
				"MATCHMAKINGPOOL_s": "Any",
				"STORMSHIELDDEFENSETYPE_i": 0,
				"HOTFIXVERSION_i": 0,
				"PLAYLISTNAME_s": "",
				"MATCHSTARTTIME_s": "",
				"SESSIONKEY_s": "",
				"TENANT_s": "Fortnite",
				"BEACONPORT_i": 0
			},
			"publicPlayers": [],
			"privatePlayers": [],
			"totalPlayers": 0,
			"allowJoinInProgress": false,
			"shouldAdvertise": false,
			"isDedicated": false,
			"usesStats": false,
			"allowInvites": false,
			"usesPresence": false,
			"allowJoinViaPresence": false,
			"allowJoinViaPresenceFriendsOnly": false,
			"buildUniqueId": "",
			"lastUpdated": "",
			"started": true		
		});
	});		
		
	app.all("/fortnite/api/matchmaking/session/:sId/join", (req, res) => {
		res.status(204).send();
	});
	*/
};