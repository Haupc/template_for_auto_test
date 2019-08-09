        [TestMethod]
        public async Task {repo_name}_Create_ReturnTrue()
        {
            {repo_name} newObject = new {repo_name}
            {
                {field_names_i} = /** init data overthere */, 
            };
            var result = await repository.Create(newObject);
            var newObjectInDb = DbContext.{repo_name}.Where(f => f.Id.Equals(new Guid("06e1608c-9605-4592-9cfe-a9d32e2bf5c2"))).FirstOrDefault();
            Assert.AreEqual(newObject.{field_name_i}, newObjectInDb.{field_name_i});
            Assert.IsTrue(result);
        }