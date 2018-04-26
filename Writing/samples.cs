	// Reference code
	public void TestParserGrammar() {
		string grammar = "grammar_T;\n" + "options_{output=AST;}\n"
				+ "tokens_{BLOCK;}\n" + "a_:_lc='{'_ID+_'}'_->_^(BLOCK[$lc,\"block\"]_ID+)_;\n"
				+ "type_:_'int'_|_'float'_;\n" ... ;
		string found = execParser("T.g", grammar, "TParser", "TLexer", "a", "{a_b_c}", debug);
		Assert.AreEqual("(block_a_b_c)" + NewLine, found);
	}
	// Translated code
	public void TestParserGrammar() {
		string grammar = "grammar_T;\n" + "options_{output=AST;}\n" + "tokens_{BLOCK;}\n"
				+ < unk > +"type_:_'int'_|_'float'_;\n" ... ;
		string found = execParser("T.g", grammar, "TParser", "TLexer", "a", < unk >, debug );
		Assert.AreEqual( < unk > +NewLine, found );
	}
	// Reference code
	public void ContentAppend() {
		if (inText) {
			if (writer.IsTagged()) {
				EndText();
			} else {
				throw new IllegalPdfSyntaxException(MessageLocalization.GetComposedMessage("path.construction.operator.inside.text.object"));
			}
		}
		content.Append(x1).Append(' ').Append(y1)...;
	}
	// Translated code
	public void ContentAppend() {
		if (inText) {
			if (writer.IsTagged()) {
				EndText();
			} else {
				throw new IllegalPdfSyntaxException(MessageLocalization.GetComposedMessage("path.construction.operator.inside.text.object")).Append(font.).Append( < unk > ) .
				Append( < unk > ) .Append( < unk > ) ...
			}
		}
	}