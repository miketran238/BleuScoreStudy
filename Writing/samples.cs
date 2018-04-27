		// Reference code
		public void TestImaginaryTokenNoCopyFromTokenSetText() {
			string grammar = "grammar_T;\n" + "options_{output=AST;}\n" + ...
			string found = execParser("T.g", grammar, "TParser", "TLexer", ...;
			Assert.AreEqual("(block_a_b_c)" + NewLine, found);
		}
		// Translated code
		public void TestImaginaryTokenNoCopyFromTokenSetText() {
			string grammar = "grammar_T;\n" + ...;
			string found = execParser("T.g", grammar, ...;
			Assert.AreEqual( < unk > + NewLine, found );
		}
		// Reference code
		public void CurveTo ( float x1 , float y1 ...) {
			if (inText) {
				if (writer.IsTagged()) {
					EndText();
				} else {
					throw new IllegalPdfSyntaxException(...);
				}
			}
			content.Append(x1).Append(' ').Append(y1)...;
		}
		// Translated code
		public void CurveTo ( float x1 , float y1 ...){
			if (inText) {
				if (writer.IsTagged()) {
					EndText();
				} else {
					throw new IllegalPdfSyntaxException(...).Append(font.).Append(...
					Append( < unk > ) ...
				}
			}
		}