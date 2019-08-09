        [TestMethod]
        public async Task {repo_name}_Update_ReturnTrue()
        {
            {repo_name} newObject = new {repo_name}
            {
                {field_name_i} = /** data overthere */,
            };
            var result = await repository.Update(newObject);
            var newObjectOInDb = DbContext.{repo_name}.Where(p => p.Id.Equals(new Guid(/* use Id init above */))).AsNoTracking().FirstOrDefault();
            Assert.AreEqual(newObject.{field_name_i}, newObjectOInDb.{field_name_i});
            Assert.IsTrue(result);
        }