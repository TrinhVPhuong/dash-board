FROM node:lts-alpine
ENV NODE_ENV=production
WORKDIR /home/app
COPY ["package.json", "package-lock.json*", "npm-shrinkwrap.json*", "./"]
RUN npm install --production --silent && mv node_modules ../
COPY . .
EXPOSE 3000
RUN chown -R node /home/app
USER node
CMD ["npm", "run", "build"]