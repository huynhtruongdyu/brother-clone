const gulp = require('gulp');
const sass = require('sass');
const { Transform } = require('stream');
const path = require('path');
const cleanCSS = require('gulp-clean-css');
const rename = require('gulp-rename');
const terser = require('gulp-terser');

const paths = {
  scssWatch: 'Assets/Scss/**/*.scss',
  scss: 'Assets/Scss/main.scss',
  js: 'Assets/Scripts/**/*.js',
  cssDest: 'wwwroot/css',
  jsDest: 'wwwroot/js'
};

function compileSass() {
  return new Transform({
    objectMode: true,
    transform(file, enc, cb) {
      if (file.isBuffer()) {
        const result = sass.compileString(file.contents.toString(), {
          loadPaths: [path.dirname(file.path)]
        });
        file.contents = Buffer.from(result.css);
        file.path = file.path.replace(/\.scss$/, '.css');
      }
      cb(null, file);
    }
  });
}

function styles() {
  return gulp.src(paths.scss)
    .pipe(compileSass())
    .pipe(cleanCSS())
    .pipe(rename('site.css'))
    .pipe(gulp.dest(paths.cssDest));
}

function scripts() {
  return gulp.src(paths.js)
    .pipe(terser({
        compress: { drop_console: true },
        mangle: true
    }))
    .pipe(gulp.dest(paths.jsDest));
}

function watch() {
  gulp.watch(paths.scssWatch, styles);
  gulp.watch(paths.js, scripts);
}

exports.styles = styles;
exports.scripts = scripts;
exports.watch = watch;
exports.default = gulp.parallel(styles, scripts);
