        //Deactive
        [TestMethod]
        public async Task {repo_name}_Deactive()
        {
            var result = await repository.Deactive(CreatGuid("NewGuid"));
            var {repo_name}AfterDel = await DbContext.{repo_name}
                .Where(cg => cg.Id == CreatGuid("NewGuid")
                .AsNoTracking()
                .FirstOrDefaultAsync();
            Assert.AreEqual(true, {repo_name}AfterDel.Disabled);
            Assert.IsTrue(result);
        }

        //Active
        [TestMethod]
        public async Task {repo_name}_Active()
        {
            var result = await repository.Active(CreatGuid("NewGuid"));
            var {repo_name}AfterDel = await DbContext.{repo_name}
                .Where(cg => cg.Id == CreatGuid("NewGuid"))
                .AsNoTracking()
                .FirstOrDefaultAsync();
            Assert.AreEqual(false, {repo_name}AfterDel.Disabled);
            Assert.IsTrue(result);
        }