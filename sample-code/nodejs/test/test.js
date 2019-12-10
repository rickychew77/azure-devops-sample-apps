const { describe } = require('mocha');
const chai = require('chai');
const chaiHttp = require('chai-http');
const app = require('../app');

// Configure chai
chai.use(chaiHttp);
chai.should();

describe('Simple test suite (with chai):', function () {
    it('1 === 1 should be true', function () {
        chai.expect(1).to.equal(1);
    });
});

describe("GET /", () => {
    // Test to get users
    it("should get respond with a resource", (done) => {
        chai.request(app)
            .get('/users')
            .end((err, res) => {
                chai.expect(res.status).to.equal(200);
                chai.expect(res.text).to.equal("respond with list of users");
                done();
            });
    });
    it("should get respond with user's name", (done) => {
        const id = 1;
        chai.request(app)
            .get(`/users/${id}`)
            .end((err, res) => {
                chai.expect(res.status).to.equal(200);
                chai.expect(res.text).to.equal("Luky");
                done();
            });
    });
    it("should get 404, due to not found user id", (done) => {
        const id = 2;
        chai.request(app)
            .get(`/users/${id}`)
            .end((err, res) => {
                chai.expect(res.status).to.equal(404);
                done();
            });
    });
});