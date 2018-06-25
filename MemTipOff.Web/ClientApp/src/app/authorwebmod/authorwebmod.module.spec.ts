import { AuthorwebmodModule } from './authorwebmod.module';

describe('AuthorwebmodModule', () => {
  let authorwebmodModule: AuthorwebmodModule;

  beforeEach(() => {
    authorwebmodModule = new AuthorwebmodModule();
  });

  it('should create an instance', () => {
    expect(authorwebmodModule).toBeTruthy();
  });
});
