var express = require('express');
var router = express.Router();

/* GET users listing. */
router.get('/', function (req, res, next) {
  res.send('respond with list of users');
});

router.get('/:id', function (req, res, next) {
  if (req.params.id == 1) {
    res.send('Luky');
  } else {
    res.status(404).send();
  }
});

module.exports = router;
