var express = require('express');
var router = express.Router();

/* GET accounts listing. */
router.get('/', function(req, res, next) {
  res.send('respond with with list of accounts');
});

module.exports = router;;
